using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace Mechanics
{
    static public class Enigma
    {
        public const int SHIFT = 65;
        public const int ALPHABET_LENGHT = 26;
        static private Rotor[] rotors = new Rotor[3];
        static private Reflector reflector = null;
        static private int[] initPos = new int[3];
        static private string encryptedText = "";

        static private int mod(int num1, int num2)
        {
            int answer = num1 % num2;
            if(answer < 0)
            {
                answer = answer + num2;
            }
            return answer;
        }
        static public int getCharacterNumber(char ch)
        {
            return (int)(ch - SHIFT);
        }
        static public char getCharacterByNumber(int number)
        {
            return (char)(number + SHIFT);
        }
        static public void setInitPos(int pos1, int pos2, int pos3)
        {
            initPos[0] = pos1;
            initPos[1] = pos2;
            initPos[2] = pos3;
        }
        static public bool setRotorsType(int[] types)
        {
            if(types[0] == types[1] || types[1] == types[2] || types[2] == types[0])
            {
                return false;
            }
            else
            {
                for(int i = 0; i < rotors.Length; i++)
                {
                    switch (types[i])
                    {
                        case 1:
                            rotors[i] = new Rotor1(initPos[i]);
                            break;
                        case 2:
                            rotors[i] = new Rotor2(initPos[i]);
                            break;
                        case 3:
                            rotors[i] = new Rotor3(initPos[i]);
                            break;
                        case 4:
                            rotors[i] = new Rotor4(initPos[i]);
                            break;
                        case 5:
                            rotors[i] = new Rotor5(initPos[i]);
                            break;
                        case 6:
                            rotors[i] = new Rotor6(initPos[i]);
                            break;
                        case 7:
                            rotors[i] = new Rotor7(initPos[i]);
                            break;
                        case 8:
                            rotors[i] = new Rotor8(initPos[i]);
                            break;
                    }
                }
                return true;
            }
            
        }
        static public bool setReflectorType(int type)
        {
            if (type == -1)
            {
                return false;
            }
            else
            {
                switch(type)
                {
                    case 0:
                        reflector = new Reflector1();
                        break;
                    case 1:
                        reflector = new Reflector2();
                        break;
                    case 2:
                        reflector = new Reflector3();
                        break;
                    case 3:
                        reflector = new Reflector4();
                        break;
                }
                return true;
            }
        }
        static public string encrypt(string text)
        {
            //Как зашифровать?
            //Буквы пронумерованы [0; 25]
            //
            //1. Входной символ превращается в соответств. число
            //   Повернуть ротор1
            //
            //2. Число складывается по модулю 26 с нач. позицией ротора 1.
            //   По результату сложение находится соответствие в табличке
            //   Если ротор 1 уставнолен на букву сдвига, сдвинуть ротор2
            //
            //3. Результат подается на ротор 2 и обрабатывается по формуле:
            //   ротор2.символ = вход + (ротор2.позиция - ротор1.позиция)
            //   По результату формулы находится соответсвие в табличке
            //   Если ротор 2 установлен на буку сдвига, сдвинуть ротор3
            //
            //4. Результат подается на ротор 3  и обрабатывается по формуле:
            //   ротор3.символ = вход + (ротор3.позиция - ротор2.позиция)
            //   По результату формулы находится соответсвие в табличке
            //
            //5. Отражение на рефлекторе. Результат подается на рефлектор и обрабатывается так:
            //   рефлектор.символ = вход - ротор3.позиция
            //   По результату формулы находится соответсвие в табличке
            //
            //6. Идем в обратную сторону. Результат отражения на ротор3.
            //   ротор3.символ = вход + ротор3.позиция
            //   По результату формулы находится соответсвие в табличке
            //
            //7. Результат на ротор2. 
            //   ротор2.символ = вход - (ротор3.позиция - ротор2.позиция)
            //   По результату формулы находится соответсвие в табличке
            //
            //8. Результат подается на ротор1.
            //   ротор1.символ = вход - (ротор2.позиция - ротор1.позиция)
            //   По результату формулы находится соответсвие в табличке
            //
            //9. Предварительный выход обрабатывается так
            //   Предв. выход = результат - ротор1.позиция
            //
            //10.Проверить предв.выход на наличие в патч-панели
            //   Если символа нет в патч-панели, считать его выходом,
            //   иначе поменять его на указанный в патч-панели
            //
            //11. Превратить число в символ и записать в выходную строку

            char[] inputText = text.ToCharArray();
            encryptedText = "";
            for(int i = 0; i < inputText.Length; i++)
            {
                //1.
                int ch = getCharacterNumber(inputText[i]);
                if(rotors[0].incrementAndCheck())
                {
                    if(rotors[1].incrementAndCheck())
                    {
                        rotors[2].increment();
                    }
                }
                //2.
                ch = (rotors[0].Position + ch) % ALPHABET_LENGHT; 
                ch = rotors[0].passThroughTheRotor(ch);

                //3.
                ch = mod(ch + (rotors[1].Position - rotors[0].Position), ALPHABET_LENGHT);
                ch = rotors[1].passThroughTheRotor(ch);

                //4.
                ch = mod(ch + (rotors[2].Position - rotors[1].Position), ALPHABET_LENGHT);
                ch = rotors[2].passThroughTheRotor(ch);

                //5.
                ch = mod(ch - rotors[2].Position, ALPHABET_LENGHT);
                ch = reflector.passThroughTheReflector(ch);

                //6.
                ch = (ch + rotors[2].Position) % ALPHABET_LENGHT;
                ch = rotors[2].passThroughTheRotorReverse(ch);

                //7.
                ch = mod(ch - (rotors[2].Position - rotors[1].Position), ALPHABET_LENGHT);
                ch = rotors[1].passThroughTheRotorReverse(ch);

                //8.
                ch = mod(ch - (rotors[1].Position - rotors[0].Position), ALPHABET_LENGHT);
                ch = rotors[0].passThroughTheRotorReverse(ch);

                //9.
                ch = mod(ch - rotors[0].Position, ALPHABET_LENGHT);

                //10.
                ch = PatchPanel.passThroughPanel(ch);

                //11.
                char result = getCharacterByNumber(ch);
                encryptedText += result;
            }
            return encryptedText;
        }
    }

    abstract public class Reflector
    {
        protected KeyValuePair<int, int>[] reflectionTable = null;

        public virtual int passThroughTheReflector(int input)
        {
            int output = -1;
            for(int i = 0; i < reflectionTable.Length; i++)
            {
                if((reflectionTable[i].Key - Enigma.SHIFT) == input)
                {
                    output = reflectionTable[i].Value - Enigma.SHIFT;
                    return output;
                }
            }
            for(int i = 0; i < reflectionTable.Length; i++)
            {
                if((reflectionTable[i].Value - Enigma.SHIFT) == input)
                {
                    output = reflectionTable[i].Key - Enigma.SHIFT;
                    return output;
                }
            }
            return output;
        }
    }

    abstract public class Rotor
    {
        protected int position = 0;
        protected string table = null;
        protected char specialChar = '\0';
        protected char additionalSpecialChar = '\0';

        public int Position
        { get { return position; } set { position = value; } }

        public virtual int passThroughTheRotor(int input)
        {
            char[] chars = table.ToCharArray();
            return (int)chars[input] - Enigma.SHIFT;
        }
        public virtual int passThroughTheRotorReverse(int input)
        {
            int result = -1;
            char[] chars = table.ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                if(chars[i] == (char)(input + Enigma.SHIFT))
                {
                    result = i;
                }
            }
            return result;
        }
        public virtual void increment()
        {
            if (position < 25)
            {
                position++;
            }
            else
            {
                position = 0;
            }
        }
        public virtual bool incrementAndCheck()
        {
            increment();
            if(position == specialChar - Enigma.SHIFT ||(additionalSpecialChar != '\0' && 
               position == additionalSpecialChar - Enigma.SHIFT))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Rotor1 : Rotor
    {
        public Rotor1(int pos)
        {
            position = pos;
            specialChar = 'R';
            table = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
        }
    }

    public class Rotor2 : Rotor
    {
        public Rotor2(int pos)
        {
            position = pos;
            specialChar = 'F';
            table = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
        }
    }

    public class Rotor3 : Rotor
    {
        public Rotor3(int pos)
        {
            position = pos;
            specialChar = 'W';
            table = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
        }
    }

    public class Rotor4 : Rotor
    {
        public Rotor4(int pos)
        {
            position = pos;
            specialChar = 'K';
            table = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
        }
    }

    public class Rotor5 : Rotor
    {
        public Rotor5(int pos)
        {
            position = pos;
            specialChar = 'A';
            table = "VZBRGITYUPSDNHLXAWMJQOFECK";
        }
    }

    public class Rotor6 : Rotor
    {
        public Rotor6(int pos)
        {
            position = pos;
            specialChar = 'A';
            additionalSpecialChar = 'N';
            table = "JPGVOUMFYQBENHZRDKASXLICTW";
        }
    }

    public class Rotor7 : Rotor
    {
        public Rotor7(int pos)
        {
            position = pos;
            specialChar = 'A';
            additionalSpecialChar = 'N';
            table = "NZJHGRCXMYSWBOUFAIVLPEKQDT";
        }
    }

    public class Rotor8 : Rotor
    {
        public Rotor8(int pos)
        {
            position = pos;
            specialChar = 'A';
            additionalSpecialChar = 'N';
            table = "FKQHTLXOCBJSPDZRAMEWNIUYGV";
        }
    }

    public class Reflector1 : Reflector
    {
        public Reflector1()
        {
            this.reflectionTable = new KeyValuePair<int, int>[13] {
                new KeyValuePair<int, int>('A', 'Y'),
                new KeyValuePair<int, int>('B', 'R'),
                new KeyValuePair<int, int>('C', 'U'),
                new KeyValuePair<int, int>('D', 'H'),
                new KeyValuePair<int, int>('E', 'Q'),
                new KeyValuePair<int, int>('F', 'S'),
                new KeyValuePair<int, int>('G', 'L'),
                new KeyValuePair<int, int>('I', 'P'),
                new KeyValuePair<int, int>('J', 'X'),
                new KeyValuePair<int, int>('K', 'N'),
                new KeyValuePair<int, int>('M', 'O'),
                new KeyValuePair<int, int>('T', 'Z'),
                new KeyValuePair<int, int>('V', 'W')
            };
        }
    }

    public class Reflector2 : Reflector
    {
        public Reflector2()
        {
            this.reflectionTable = new KeyValuePair<int, int>[13] {
                new KeyValuePair<int, int>('A', 'F'),
                new KeyValuePair<int, int>('B', 'V'),
                new KeyValuePair<int, int>('C', 'P'),
                new KeyValuePair<int, int>('D', 'J'),
                new KeyValuePair<int, int>('E', 'I'),
                new KeyValuePair<int, int>('G', 'O'),
                new KeyValuePair<int, int>('H', 'Y'),
                new KeyValuePair<int, int>('K', 'R'),
                new KeyValuePair<int, int>('L', 'Z'),
                new KeyValuePair<int, int>('M', 'X'),
                new KeyValuePair<int, int>('N', 'W'),
                new KeyValuePair<int, int>('T', 'Q'),
                new KeyValuePair<int, int>('S', 'U')
            };
        }
    }

    public class Reflector3 : Reflector
    {
        public Reflector3()
        {
            this.reflectionTable = new KeyValuePair<int, int>[13] {
                new KeyValuePair<int, int>('A', 'E'),
                new KeyValuePair<int, int>('B', 'N'),
                new KeyValuePair<int, int>('C', 'K'),
                new KeyValuePair<int, int>('D', 'Q'),
                new KeyValuePair<int, int>('F', 'U'),
                new KeyValuePair<int, int>('G', 'Y'),
                new KeyValuePair<int, int>('H', 'W'),
                new KeyValuePair<int, int>('I', 'J'),
                new KeyValuePair<int, int>('L', 'O'),
                new KeyValuePair<int, int>('M', 'P'),
                new KeyValuePair<int, int>('R', 'X'),
                new KeyValuePair<int, int>('S', 'Z'),
                new KeyValuePair<int, int>('T', 'V')
            };
        }
    }

    public class Reflector4 : Reflector
    {
        public Reflector4()
        {
            this.reflectionTable = new KeyValuePair<int, int>[13] {
                new KeyValuePair<int, int>('A', 'R'),
                new KeyValuePair<int, int>('B', 'D'),
                new KeyValuePair<int, int>('C', 'O'),
                new KeyValuePair<int, int>('E', 'J'),
                new KeyValuePair<int, int>('F', 'N'),
                new KeyValuePair<int, int>('G', 'T'),
                new KeyValuePair<int, int>('H', 'K'),
                new KeyValuePair<int, int>('V', 'I'),
                new KeyValuePair<int, int>('L', 'M'),
                new KeyValuePair<int, int>('P', 'W'),
                new KeyValuePair<int, int>('Q', 'Z'),
                new KeyValuePair<int, int>('S', 'X'),
                new KeyValuePair<int, int>('U', 'Y')
            };
        }
    }

    public static class PatchPanel
    {
        private static KeyValuePair<int, int>[] patchPanel = new KeyValuePair<int, int>[6];
        public static bool Init(ref List<TextBox> patches)
        {
            if(patches == null || patches.Count != 12)
            {
                return false;
            }
            else
            {
                int j = 0;
                for(int i = 0; i < patches.Count; i++)
                {
                    if(patches[i].Text != "" && patches[i + 1].Text != "")
                    {
                        patchPanel[j] = new KeyValuePair<int, int>(Enigma.getCharacterNumber(patches[i].Text.ToCharArray()[0]),
                            Enigma.getCharacterNumber(patches[i + 1].Text.ToCharArray()[0]));
                        j++;
                    }
                }
                return true;
            }
        }
        public static int passThroughPanel(int symbol)
        {
            int output = symbol;
            for (int i = 0; i < patchPanel.Length; i++)
            {
                if (patchPanel[i].Key == symbol)
                {
                    output = patchPanel[i].Value;
                    return output;
                }
            }
            for (int i = 0; i < patchPanel.Length; i++)
            {
                if (patchPanel[i].Value == symbol)
                {
                    output = patchPanel[i].Key;
                    return output;
                }
            }
            return output;
        }
    }
}