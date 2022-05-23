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
        private static Dictionary<char, int> symbolCodePairs = new Dictionary<char, int>();

        //указатель на начало гаммы
        private static int pointer;

        //Modulo
        private static int mod(int num1, int num2)
        {
            int answer = num1 % num2;
            if (answer < 0)
            {
                answer = answer + num2;
            }
            return answer;
        }

        //получить число из массива его разрядов
        private static int toIntFromArray(int[] arr)
        {
            int answer = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                answer += arr[i] * (int)System.Math.Pow(10, i);
            }
            return answer;
        }

        //разбить число на разряды и записать в массив
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

        //заполнение таблички
        public static void Init()
        {
            symbolCodePairs.Add('A', 5);
            symbolCodePairs.Add('B', 87);
            symbolCodePairs.Add('C', 80);
            symbolCodePairs.Add('D', 83);
            symbolCodePairs.Add('E', 3);
            symbolCodePairs.Add('F', 92);
            symbolCodePairs.Add('G', 95);
            symbolCodePairs.Add('H', 98);
            symbolCodePairs.Add('I', 1);
            symbolCodePairs.Add('J', 84);
            symbolCodePairs.Add('K', 88);
            symbolCodePairs.Add('L', 93);
            symbolCodePairs.Add('M', 96);
            symbolCodePairs.Add('N', 7);
            symbolCodePairs.Add('O', 2);
            symbolCodePairs.Add('P', 85);
            symbolCodePairs.Add('Q', 89);
            symbolCodePairs.Add('R', 4);
            symbolCodePairs.Add('S', 0);
            symbolCodePairs.Add('T', 6);
            symbolCodePairs.Add('U', 82);
            symbolCodePairs.Add('V', 99);
            symbolCodePairs.Add('W', 91);
            symbolCodePairs.Add('X', 81);
            symbolCodePairs.Add('Y', 97);
            symbolCodePairs.Add('Z', 86);
            symbolCodePairs.Add('.', 90);
            symbolCodePairs.Add('/', 94);
        }

        //удаление пробелов
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

        //получить предварительный шифр
        public static int[] getPreliminaryCipher(char[] chars)
        {
            //хранит предв. шифр
            int[] result = null;

            //длина пред. шифра
            int length = 0;

            //вычисляем длину шифра
            foreach (char ch in chars)
            {
                int temp;
                symbolCodePairs.TryGetValue(ch, out temp);
                if (temp < 10)
                {
                    length++;
                }
                else
                {
                    length += 2;
                }
            }

            //делаем длину массива кратной 5
            if (length % 5 != 0)
            {
                result = new int[(length / 5 + 1) * 5];
            }
            else
            {
                result = new int[length];
            }

            //создание пред. шифра
            //в соответствие каждой букве ставится ее код из таблицы
            int j = 0;
            int code;
            for (int i = 0; i < chars.Length; i++)
            {
                symbolCodePairs.TryGetValue(chars[i], out code);
                if (code < 10)
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

            //возврат окружению пред. шифра
            return result;
        }

        //вычислить указатель из трех частей (страница, строка, столбец)
        public static void setPointer(int part1, int part2, int part3)
        {
            pointer = part1 * 100;
            pointer += part2 * 10;
            pointer += part3;
        }

        //создание шифра
        public static int[] getCipher(int[] preCipher, string gamma)
        {
            //для шифра
            int[] cipher = new int[preCipher.Length + 5];

            //для гаммы
            int[] intGamma = toIntArray(gamma);

            //временное хранилище для 5 цифр
            int[] tempArr = new int[5];

            //эти переменные нужны для шифрования указателя
            //переменная для четвертой с начала пятерки символов
            int fourthBlock = 0;
            //для третьей с конца пятерки
            int thirdFromEndBlock = 0;

            //сложение цифр пред. шифра с цифрами гаммы по модулю 10
            int j = 5;
            for (int i = 0; i < intGamma.Length; i++)
            {
                cipher[j] = mod(preCipher[i] + intGamma[i], 10);
                j++;
            }

            //запись во временный архив четвертой пятерки
            j = 0;
            for (int i = 5 * 4; i < 5 * 4 + 5; i++)
            {
                tempArr[j] = cipher[i];
                j++;
            }
            //прервращение массива в число
            fourthBlock = toIntFromArray(tempArr);

            //запись во временный архив третьей с конца пятерки
            j = 0;
            for (int i = cipher.Length - 5 * 3; i < cipher.Length; i++)
            {
                tempArr[j] = cipher[i];
                j++;
            }
            //превращение массива в число
            thirdFromEndBlock = toIntFromArray(tempArr);

            //шифрование указателя на начало гаммы
            pointer = mod(pointer + fourthBlock, 10);
            pointer = mod(pointer + thirdFromEndBlock, 10);

            //разбиение указателя на разряды и запись в шифр
            cipher[0] = pointer / 10000;
            cipher[1] = pointer % 10000 / 1000;
            cipher[2] = pointer % 1000 / 100;
            cipher[3] = pointer % 100 / 10;
            cipher[4] = pointer % 10;

            //возврат шифра
            return cipher;
        }
    }
}