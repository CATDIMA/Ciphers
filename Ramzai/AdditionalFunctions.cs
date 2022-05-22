using System.Collections.Generic;

namespace Functions
{
    public static class Function
    {
        // Шифр Зорге использует SUBWAY для построения табличики
        // и анаграмму ASINTOER
        //
        // вид таблички:
        //
        //  -   0   1   2   3   4   5   6   7   8   9
        //  -   S   I   O   E   R   A   T   N   -   -
        //  8   C   X   U   D   J   P   Z   B   K   Q
        //  9   .   W   F   L   /   G   M   Y   H   V
        //
        // По этой табличке буквы ASINTOER кодируются от 0 до 7
        // остальные от 80 до 99 (номер строки; номер столбца)
        // Чтобы не грузить машину бестолковыми вычислениями постоянной таблицы,
        // заполним ее сами
        private static Dictionary<char, int> symbolCipherPairs = new Dictionary<char, int>();
        private static int[] pointerDigits = new int[5];
        private static int pointer;
        private static int mod(int num1, int num2)
        {
            int answer = num1 % num2;
            if (answer < 0)
            {
                answer = answer + num2;
            }
            return answer;
        }

        private static int toIntFromArray(int[] arr)
        {
            int answer = 0;
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                answer += arr[i] * (int)System.Math.Pow(10, i);
            }
            return answer;
        }

        private static int[] toIntArray(string str)
        {
            char[] chars = str.ToCharArray();
            int[] result = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                result[i] = int.Parse(chars[i].ToString());
            }
            return result;
        }

        public static void Init()
        {
            symbolCipherPairs.Add('A', 5);
            symbolCipherPairs.Add('B', 87);
            symbolCipherPairs.Add('C', 80);
            symbolCipherPairs.Add('D', 83);
            symbolCipherPairs.Add('E', 3);
            symbolCipherPairs.Add('F', 92);
            symbolCipherPairs.Add('G', 95);
            symbolCipherPairs.Add('H', 98);
            symbolCipherPairs.Add('I', 1);
            symbolCipherPairs.Add('J', 84);
            symbolCipherPairs.Add('K', 88);
            symbolCipherPairs.Add('L', 93);
            symbolCipherPairs.Add('M', 96);
            symbolCipherPairs.Add('N', 7);
            symbolCipherPairs.Add('O', 2);
            symbolCipherPairs.Add('P', 85);
            symbolCipherPairs.Add('Q', 89);
            symbolCipherPairs.Add('R', 4);
            symbolCipherPairs.Add('S', 0);
            symbolCipherPairs.Add('T', 6);
            symbolCipherPairs.Add('U', 82);
            symbolCipherPairs.Add('V', 99);
            symbolCipherPairs.Add('W', 91);
            symbolCipherPairs.Add('X', 81);
            symbolCipherPairs.Add('Y', 97);
            symbolCipherPairs.Add('Z', 86);
            symbolCipherPairs.Add('.', 90);
            symbolCipherPairs.Add('/', 94);
        }

        public static string removeSpaces(string str)
        {
            string result = "";
            foreach (char ch in str)
            {
                if (ch != ' ')
                {
                    result += ch;
                }
            }
            return result;
        }

        public static int[] getPreliminaryCipher(char[] chars)
        {
            //косяк на 7-8 итерации
            int[] result = null;
            int length = 0;
            foreach(char ch in chars)
            {
                int temp;
                symbolCipherPairs.TryGetValue(ch, out temp);
                if (temp < 10)
                {
                    length++;
                }
                else
                {
                    length += 2;
                }
            }
            if(length % 5 != 0)
            {
                result = new int[(length / 5 + 1) * 5];
            }
            else
            {
                result = new int[length];
            }

            int j = 0;
            int code;
            for (int i = 0; i < chars.Length; i++)
            {
                symbolCipherPairs.TryGetValue(chars[i], out code);
                if(code < 10)
                {
                    result[j] = code;
                    j++;
                }
                else
                {
                    result[j] = code / 10;
                    result[j + 1] = code % 10;
                    j += 2;
                }
            }
            return result;
        }

        public static void setPointer(int part1, int part2, int part3)
        {
            pointer  = part1 * 100;
            pointer += part2 * 10;
            pointer += part3;
        }

        public static int[] getCipher(int[] preCipher, string gamma)
        {
            int[] cipher = new int[preCipher.Length + 5];
            int[] intGamma = toIntArray(gamma);
            int[] tempArr = new int[5];
            int fourthBlock = 0;
            int thirdFromEndBlock = 0;

            int j = 5;
            for(int i = 0; i < intGamma.Length; i++)
            {
                cipher[j] = mod(preCipher[i] + intGamma[i], 10);
                j++;
            }

            j = 0;
            for(int i = 5 * 4; i < 5 * 4 + 5; i++)
            {
                tempArr[j] = cipher[i];
                j++;
            }
            fourthBlock = toIntFromArray(tempArr);

            j = 0;
            for(int i = cipher.Length - 5 * 3; i < cipher.Length; i++)
            {
                tempArr[j] = cipher[i];
                j++;
            }
            thirdFromEndBlock = toIntFromArray(tempArr);

            pointer = mod(pointer + fourthBlock, 10);
            pointer = mod(pointer + thirdFromEndBlock, 10);

            cipher[0] = pointer / 10000;
            cipher[1] = pointer % 10000 / 1000;
            cipher[2] = pointer % 1000 / 100;
            cipher[3] = pointer % 100 / 10;
            cipher[4] = pointer % 10;
            return cipher;
        }
    }
}