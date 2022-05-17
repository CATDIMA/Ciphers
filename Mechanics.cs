using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace Mechanics
{
    public enum RotorType
    {
        NONE,
        TYPE1,
        TYPE2,
        TYPE3,
        TYPE4,
        TYPE5,
        TYPE6,
        TYPE7,
        TYPE8
    }

    public enum ReflectorType
    {
        NONE,
        TYPE1,
        TYPE2,
        TYPE3,
        TYPE4
    }

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
        protected ReflectorType reflectorType = ReflectorType.NONE;
        public ReflectorType ReflectorType
        { get { return reflectorType; } }
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
        protected RotorType type = RotorType.NONE;
        protected int position = 0;
        protected KeyValuePair<int, int>[] table = null;
        protected char specialChar = '\0';
        protected char additionalSpecialChar = '\0';

        public RotorType Type
        { get { return type; } }
        public int Position
        { get { return position; } set { position = value; } }

        public virtual int passThroughTheRotor(int input)
        {
            int output = -1;
            for(int i = 0; i < table.Length; i++)
            {
                if((table[i].Key - Enigma.SHIFT) == input)
                {
                    output = table[i].Value - Enigma.SHIFT;
                }
            }
            return output;
        }
        public virtual int passThroughTheRotorReverse(int input)
        {
            int output = -1;
            for (int i = 0; i < table.Length; i++)
            {
                if ((table[i].Value - Enigma.SHIFT) == input)
                {
                    output = table[i].Key - Enigma.SHIFT;
                }
            }
            return output;
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
            type = RotorType.TYPE1;
            specialChar = 'R';
            table = new KeyValuePair<int, int>[26] {
                new KeyValuePair<int, int>('A', 'E'),
                new KeyValuePair<int, int>('B', 'K'),
                new KeyValuePair<int, int>('C', 'M'),
                new KeyValuePair<int, int>('D', 'F'),
                new KeyValuePair<int, int>('E', 'L'),
                new KeyValuePair<int, int>('F', 'G'),
                new KeyValuePair<int, int>('G', 'D'),
                new KeyValuePair<int, int>('H', 'Q'),
                new KeyValuePair<int, int>('I', 'V'),
                new KeyValuePair<int, int>('J', 'Z'),
                new KeyValuePair<int, int>('K', 'N'),
                new KeyValuePair<int, int>('L', 'T'),
                new KeyValuePair<int, int>('M', 'O'),
                new KeyValuePair<int, int>('N', 'W'),
                new KeyValuePair<int, int>('O', 'Y'),
                new KeyValuePair<int, int>('P', 'H'),
                new KeyValuePair<int, int>('Q', 'X'),
                new KeyValuePair<int, int>('R', 'U'),
                new KeyValuePair<int, int>('S', 'S'),
                new KeyValuePair<int, int>('T', 'P'),
                new KeyValuePair<int, int>('U', 'A'),
                new KeyValuePair<int, int>('V', 'I'),
                new KeyValuePair<int, int>('W', 'B'),
                new KeyValuePair<int, int>('X', 'R'),
                new KeyValuePair<int, int>('Y', 'C'),
                new KeyValuePair<int, int>('Z', 'J')
            };
        }
    }

    public class Rotor2 : Rotor
    {
        public Rotor2(int pos)
        {
            position = pos;
            type = RotorType.TYPE2;
            specialChar = 'F';
            table = new KeyValuePair<int, int>[26] {
                new KeyValuePair<int, int>('A', 'A'),
                new KeyValuePair<int, int>('B', 'J'),
                new KeyValuePair<int, int>('C', 'D'),
                new KeyValuePair<int, int>('D', 'K'),
                new KeyValuePair<int, int>('E', 'S'),
                new KeyValuePair<int, int>('F', 'I'),
                new KeyValuePair<int, int>('G', 'R'),
                new KeyValuePair<int, int>('H', 'U'),
                new KeyValuePair<int, int>('I', 'X'),
                new KeyValuePair<int, int>('J', 'B'),
                new KeyValuePair<int, int>('K', 'L'),
                new KeyValuePair<int, int>('L', 'H'),
                new KeyValuePair<int, int>('M', 'W'),
                new KeyValuePair<int, int>('N', 'T'),
                new KeyValuePair<int, int>('O', 'M'),
                new KeyValuePair<int, int>('P', 'C'),
                new KeyValuePair<int, int>('Q', 'Q'),
                new KeyValuePair<int, int>('R', 'G'),
                new KeyValuePair<int, int>('S', 'Z'),
                new KeyValuePair<int, int>('T', 'N'),
                new KeyValuePair<int, int>('U', 'P'),
                new KeyValuePair<int, int>('V', 'Y'),
                new KeyValuePair<int, int>('W', 'F'),
                new KeyValuePair<int, int>('X', 'V'),
                new KeyValuePair<int, int>('Y', 'O'),
                new KeyValuePair<int, int>('Z', 'E')
            };
        }
    }

    public class Rotor3 : Rotor
    {
        public Rotor3(int pos)
        {
            position = pos;
            type = RotorType.TYPE3;
            specialChar = 'W';
            table = new KeyValuePair<int, int>[26] {
                new KeyValuePair<int, int>('A', 'B'),
                new KeyValuePair<int, int>('B', 'D'),
                new KeyValuePair<int, int>('C', 'F'),
                new KeyValuePair<int, int>('D', 'H'),
                new KeyValuePair<int, int>('E', 'J'),
                new KeyValuePair<int, int>('F', 'L'),
                new KeyValuePair<int, int>('G', 'C'),
                new KeyValuePair<int, int>('H', 'P'),
                new KeyValuePair<int, int>('I', 'R'),
                new KeyValuePair<int, int>('J', 'T'),
                new KeyValuePair<int, int>('K', 'X'),
                new KeyValuePair<int, int>('L', 'V'),
                new KeyValuePair<int, int>('M', 'Z'),
                new KeyValuePair<int, int>('N', 'N'),
                new KeyValuePair<int, int>('O', 'Y'),
                new KeyValuePair<int, int>('P', 'E'),
                new KeyValuePair<int, int>('Q', 'I'),
                new KeyValuePair<int, int>('R', 'W'),
                new KeyValuePair<int, int>('S', 'G'),
                new KeyValuePair<int, int>('T', 'A'),
                new KeyValuePair<int, int>('U', 'K'),
                new KeyValuePair<int, int>('V', 'M'),
                new KeyValuePair<int, int>('W', 'U'),
                new KeyValuePair<int, int>('X', 'S'),
                new KeyValuePair<int, int>('Y', 'Q'),
                new KeyValuePair<int, int>('Z', 'O')
            };
        }
    }

    public class Rotor4 : Rotor
    {
        public Rotor4(int pos)
        {
            position = pos;
            type = RotorType.TYPE4;
            specialChar = 'K';
            table = new KeyValuePair<int, int>[26] {
                new KeyValuePair<int, int>('A', 'E'),
                new KeyValuePair<int, int>('B', 'S'),
                new KeyValuePair<int, int>('C', 'O'),
                new KeyValuePair<int, int>('D', 'V'),
                new KeyValuePair<int, int>('E', 'P'),
                new KeyValuePair<int, int>('F', 'Z'),
                new KeyValuePair<int, int>('G', 'J'),
                new KeyValuePair<int, int>('H', 'A'),
                new KeyValuePair<int, int>('I', 'Y'),
                new KeyValuePair<int, int>('J', 'Q'),
                new KeyValuePair<int, int>('K', 'U'),
                new KeyValuePair<int, int>('L', 'I'),
                new KeyValuePair<int, int>('M', 'R'),
                new KeyValuePair<int, int>('N', 'H'),
                new KeyValuePair<int, int>('O', 'X'),
                new KeyValuePair<int, int>('P', 'L'),
                new KeyValuePair<int, int>('Q', 'N'),
                new KeyValuePair<int, int>('R', 'F'),
                new KeyValuePair<int, int>('S', 'T'),
                new KeyValuePair<int, int>('T', 'G'),
                new KeyValuePair<int, int>('U', 'K'),
                new KeyValuePair<int, int>('V', 'D'),
                new KeyValuePair<int, int>('W', 'C'),
                new KeyValuePair<int, int>('X', 'M'),
                new KeyValuePair<int, int>('Y', 'W'),
                new KeyValuePair<int, int>('Z', 'B')
            };
        }
    }

    public class Rotor5 : Rotor
    {
        public Rotor5(int pos)
        {
            position = pos;
            type = RotorType.TYPE5;
            specialChar = 'A';
            table = new KeyValuePair<int, int>[26] {
                new KeyValuePair<int, int>('A', 'V'),
                new KeyValuePair<int, int>('B', 'Z'),
                new KeyValuePair<int, int>('C', 'B'),
                new KeyValuePair<int, int>('D', 'R'),
                new KeyValuePair<int, int>('E', 'G'),
                new KeyValuePair<int, int>('F', 'I'),
                new KeyValuePair<int, int>('G', 'T'),
                new KeyValuePair<int, int>('H', 'Y'),
                new KeyValuePair<int, int>('I', 'U'),
                new KeyValuePair<int, int>('J', 'P'),
                new KeyValuePair<int, int>('K', 'S'),
                new KeyValuePair<int, int>('L', 'D'),
                new KeyValuePair<int, int>('M', 'N'),
                new KeyValuePair<int, int>('N', 'H'),
                new KeyValuePair<int, int>('O', 'L'),
                new KeyValuePair<int, int>('P', 'X'),
                new KeyValuePair<int, int>('Q', 'A'),
                new KeyValuePair<int, int>('R', 'W'),
                new KeyValuePair<int, int>('S', 'M'),
                new KeyValuePair<int, int>('T', 'J'),
                new KeyValuePair<int, int>('U', 'Q'),
                new KeyValuePair<int, int>('V', 'O'),
                new KeyValuePair<int, int>('W', 'F'),
                new KeyValuePair<int, int>('X', 'E'),
                new KeyValuePair<int, int>('Y', 'C'),
                new KeyValuePair<int, int>('Z', 'K')
            };
        }
    }

    public class Rotor6 : Rotor
    {
        public Rotor6(int pos)
        {
            position = pos;
            type = RotorType.TYPE6;
            specialChar = 'A';
            additionalSpecialChar = 'N';
            table = new KeyValuePair<int, int>[26] {
                new KeyValuePair<int, int>('A', 'J'),
                new KeyValuePair<int, int>('B', 'P'),
                new KeyValuePair<int, int>('C', 'G'),
                new KeyValuePair<int, int>('D', 'V'),
                new KeyValuePair<int, int>('E', 'O'),
                new KeyValuePair<int, int>('F', 'U'),
                new KeyValuePair<int, int>('G', 'M'),
                new KeyValuePair<int, int>('H', 'F'),
                new KeyValuePair<int, int>('I', 'Y'),
                new KeyValuePair<int, int>('J', 'Q'),
                new KeyValuePair<int, int>('K', 'B'),
                new KeyValuePair<int, int>('L', 'E'),
                new KeyValuePair<int, int>('M', 'N'),
                new KeyValuePair<int, int>('N', 'H'),
                new KeyValuePair<int, int>('O', 'Z'),
                new KeyValuePair<int, int>('P', 'R'),
                new KeyValuePair<int, int>('Q', 'D'),
                new KeyValuePair<int, int>('R', 'K'),
                new KeyValuePair<int, int>('S', 'A'),
                new KeyValuePair<int, int>('T', 'S'),
                new KeyValuePair<int, int>('U', 'X'),
                new KeyValuePair<int, int>('V', 'L'),
                new KeyValuePair<int, int>('W', 'I'),
                new KeyValuePair<int, int>('X', 'C'),
                new KeyValuePair<int, int>('Y', 'T'),
                new KeyValuePair<int, int>('Z', 'W')
            };
        }
    }

    public class Rotor7 : Rotor
    {
        public Rotor7(int pos)
        {
            position = pos;
            type = RotorType.TYPE7;
            specialChar = 'A';
            additionalSpecialChar = 'N';
            table = new KeyValuePair<int, int>[26] {
                new KeyValuePair<int, int>('A', 'N'),
                new KeyValuePair<int, int>('B', 'Z'),
                new KeyValuePair<int, int>('C', 'J'),
                new KeyValuePair<int, int>('D', 'H'),
                new KeyValuePair<int, int>('E', 'G'),
                new KeyValuePair<int, int>('F', 'R'),
                new KeyValuePair<int, int>('G', 'C'),
                new KeyValuePair<int, int>('H', 'X'),
                new KeyValuePair<int, int>('I', 'M'),
                new KeyValuePair<int, int>('J', 'Y'),
                new KeyValuePair<int, int>('K', 'S'),
                new KeyValuePair<int, int>('L', 'W'),
                new KeyValuePair<int, int>('M', 'B'),
                new KeyValuePair<int, int>('N', 'O'),
                new KeyValuePair<int, int>('O', 'U'),
                new KeyValuePair<int, int>('P', 'F'),
                new KeyValuePair<int, int>('Q', 'A'),
                new KeyValuePair<int, int>('R', 'I'),
                new KeyValuePair<int, int>('S', 'V'),
                new KeyValuePair<int, int>('T', 'L'),
                new KeyValuePair<int, int>('U', 'P'),
                new KeyValuePair<int, int>('V', 'E'),
                new KeyValuePair<int, int>('W', 'K'),
                new KeyValuePair<int, int>('X', 'Q'),
                new KeyValuePair<int, int>('Y', 'D'),
                new KeyValuePair<int, int>('Z', 'T')
            };
        }
    }

    public class Rotor8 : Rotor
    {
        public Rotor8(int pos)
        {
            position = pos;
            type = RotorType.TYPE8;
            specialChar = 'A';
            additionalSpecialChar = 'N';
            table = new KeyValuePair<int, int>[26] {
                new KeyValuePair<int, int>('A', 'F'),
                new KeyValuePair<int, int>('B', 'K'),
                new KeyValuePair<int, int>('C', 'Q'),
                new KeyValuePair<int, int>('D', 'H'),
                new KeyValuePair<int, int>('E', 'T'),
                new KeyValuePair<int, int>('F', 'L'),
                new KeyValuePair<int, int>('G', 'X'),
                new KeyValuePair<int, int>('H', 'O'),
                new KeyValuePair<int, int>('I', 'C'),
                new KeyValuePair<int, int>('J', 'B'),
                new KeyValuePair<int, int>('K', 'J'),
                new KeyValuePair<int, int>('L', 'S'),
                new KeyValuePair<int, int>('M', 'P'),
                new KeyValuePair<int, int>('N', 'D'),
                new KeyValuePair<int, int>('O', 'Z'),
                new KeyValuePair<int, int>('P', 'R'),
                new KeyValuePair<int, int>('Q', 'A'),
                new KeyValuePair<int, int>('R', 'M'),
                new KeyValuePair<int, int>('S', 'E'),
                new KeyValuePair<int, int>('T', 'W'),
                new KeyValuePair<int, int>('U', 'N'),
                new KeyValuePair<int, int>('V', 'I'),
                new KeyValuePair<int, int>('W', 'U'),
                new KeyValuePair<int, int>('X', 'Y'),
                new KeyValuePair<int, int>('Y', 'G'),
                new KeyValuePair<int, int>('Z', 'V')
            };
        }
    }

    public class Reflector1 : Reflector
    {
        public Reflector1()
        {
            reflectorType = ReflectorType.TYPE1;
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
            reflectorType = ReflectorType.TYPE2;
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
            reflectorType = ReflectorType.TYPE3;
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
            reflectorType = ReflectorType.TYPE4;
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