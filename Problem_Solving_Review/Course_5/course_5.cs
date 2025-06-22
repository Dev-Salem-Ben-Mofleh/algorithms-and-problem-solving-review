using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Review.Course_5
{
    public class course_5
    {
        public class Program
        {
            public enum enPrimOrNotPtime { Prime = 1, NotPrime = 2 };
            public enum enCharType
            {
                SmallLetter = 1, CapitalLetter = 2, SpecialCharcater = 3, DigitInOrder = 4
            };
            public static void PrintHeader()
            {
                Console.WriteLine("\n\n\t\t\t Multiplication Table From 1 To 10\n");
                Console.WriteLine("\t");

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("\t" + i);
                }

                Console.WriteLine("\n_______________________________________________________________________________________________\n");

            }
            public static void PrintMultiPrintMultiplicationTable()
            {
                PrintHeader();
                for (int i = 1; i <= 10; i++)
                {
                    if (i == 10)
                        Console.Write(i + " |");
                    else
                        Console.Write(i + "  |");


                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write("\t" + i * j);
                    }
                    Console.WriteLine();

                }


            }
            public static int ReadPositiveNumber(string Message)
            {
                int Number = 0;
                do
                {
                    Console.Write(Message);
                    Number = Convert.ToInt32(Console.ReadLine());
                } while (Number <= 0);
                return Number;

            }
            private static enPrimOrNotPtime _CheckPrime(int Number)
            {
                for (int i = 2; i < Number; i++)
                {
                    if (Number % i == 0)
                        return enPrimOrNotPtime.NotPrime;
                }

                return enPrimOrNotPtime.Prime;
            }
            public static void PrintPrimeNumbersFrom1ToN(int Number)
            {
                Console.WriteLine("The Prime Numbers are : ");

                for (int i = 1; i < Number; i++)
                {
                    if (_CheckPrime(i) == enPrimOrNotPtime.Prime)
                        Console.WriteLine(i);

                }
            }
            public static bool IsPrefectNumber(int Number)
            {
                int sum = 0;
                for (int i = 1; i < Number; i++)
                {
                    if (Number % i == 0)
                    {
                        sum += i;
                    }
                }

                return sum == Number;
            }
            public static void PrintPrefectNumberOrNotPrefect(int Number)
            {
                Console.WriteLine("The Prefect Numbers are : ");

                for (int i = 1; i < Number; i++)
                {
                    if (IsPrefectNumber(i))
                        Console.WriteLine(i);

                }
            }
            public static void PrintDigets(int Number)
            {
                int Reminder = 0;
                while (Number > 0)
                {
                    Reminder = Number % 10;
                    Number = Number / 10;
                    Console.WriteLine(Reminder);
                }
            }
            public static void SumOfDigets(int Number)
            {
                int sum = 0;
                int Reminder = 0;
                while (Number > 0)
                {
                    Reminder = Number % 10;
                    Number = Number / 10;
                    sum += Reminder;
                }

                Console.WriteLine("Sum Of Digets: " + sum);

            }
            public static void ResevedNumbers(int Number)
            {
                int Reminder = 0;
                int Number2 = 0;
                while (Number > 0)
                {
                    Reminder = Number % 10;
                    Number = Number / 10;
                    Number2 = Number2 * 10 + Reminder;
                }
                Console.WriteLine("Reseved Numbers Of Digets: " + Number2);

            }
            public static int RevrseNumber(int Number)
            {
                int Reminder = 0;
                int Number2 = 0;
                while (Number > 0)
                {
                    Reminder = Number % 10;
                    Number = Number / 10;
                    Number2 = Number2 * 10 + Reminder;

                }
                return Number2;

            }
            public static int CountDigitFrequency(int Number, int DigitToCheck)
            {
                int Reminder = 0;
                int Counter = 0;
                while (Number > 0)
                {
                    Reminder = Number % 10;
                    Number = Number / 10;
                    if (Reminder == DigitToCheck)
                        Counter++;
                }
                return Counter;
            }
            public static void PrintAllDigitFrequency(int Number)
            {
                int DigitToCheck;

                for (int i = 0; i < 10; i++)
                {
                    DigitToCheck = CountDigitFrequency(Number, i);
                    if (DigitToCheck > 0)
                        Console.WriteLine("Digit : " + i + " Frequenccy Is " + DigitToCheck + " Time(s)");
                }
            }
            public static bool isPalindromeNumber(int Number)
            {
                return Number == RevrseNumber(Number);
            }
            public static void PrintInvertedNumbersPatter(int Number)
            {
                for (int i = Number; i > 0; i--)
                {

                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();

                }
            }
            public static void PrintNumbersPatter(int Number)
            {
                for (int i = 1; i <= Number; i++)
                {

                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();

                }
            }
            public static void PrintInvertedlettersPatter(int Number)
            {
                for (int i = 65 + Number - 1; i >= 65; i--)
                {
                    for (int j = 1; j <= Number - (65 + Number - 1 - i); j++)
                    {
                        Console.Write(Convert.ToChar(i));
                    }
                    Console.WriteLine();

                }
            }
            public static void PrintlettersPatter(int Number)
            {
                for (int i = 65; i <= 65 + Number - 1; i++)
                {
                    for (int j = 1; j <= i - 65 + 1; j++)
                    {
                        Console.Write(Convert.ToChar(i));
                    }
                    Console.WriteLine();

                }
            }
            public static void PrintWordsFromAAAToZZZ()
            {
                string words = "";
                for (int i = 65; i <= 90; i++)
                {
                    for (int j = 65; j <= 90; j++)
                    {
                        for (int k = 65; k <= 90; k++)
                        {
                            words += Convert.ToChar(i);
                            words += Convert.ToChar(j);
                            words += Convert.ToChar(k);

                            Console.WriteLine(words);
                            words = "";

                        }
                    }


                    Console.WriteLine();

                }
            }
            public static string ReadPassword()
            {
                string PassWord;
                Console.Write("Please Enter a 3-letter Password (All Captile )? ");
                PassWord = Console.ReadLine();

                return PassWord;
            }
            public static void GessPassword(string OriginalPassword)
            {
                string words = "";
                int Counter = 0;
                for (int i = 65; i <= 90; i++)
                {
                    for (int j = 65; j <= 90; j++)
                    {
                        for (int k = 65; k <= 90; k++)
                        {
                            words += Convert.ToChar(i);
                            words += Convert.ToChar(j);
                            words += Convert.ToChar(k);

                            Console.WriteLine(words);
                            Counter++;

                            if (OriginalPassword == words)
                            {
                                Console.WriteLine("Password is " + OriginalPassword);
                                Console.WriteLine("Found after " + Counter + "Trail(s)");
                                return;
                            }
                            words = "";

                        }
                    }


                    Console.WriteLine();

                }
            }
            public static string ReadText()
            {
                string Text;
                Console.Write("Please enter Text?\n");
                Text = Console.ReadLine();
                return Text;
            }
            public static string EncryptText(string Text, short EncryptionKey)
            {
                string EncryptText = "";
                for (int i = 0; i < Text.Length; i++)
                {
                    EncryptText += Convert.ToChar(Text[(i)] + EncryptionKey);
                }
                return EncryptText;
            }
            public static string DecryptText(string Text, short EncryptionKey)
            {
                string DecryptText = "";
                for (int i = 0; i < Text.Length; i++)
                {
                    DecryptText += Convert.ToChar(Text[(i)] - EncryptionKey);
                }
                return DecryptText;
            }
            public static void PrintEncryptTextAndDecryptText()
            {
                string TextAfterEncryption, TextAfterDecryption;
                string Text = ReadText();

                TextAfterEncryption = EncryptText(Text, 2);
                Console.WriteLine("Text After Encryption: " + TextAfterEncryption);
                TextAfterDecryption = DecryptText(TextAfterEncryption, 2);
                Console.WriteLine("Text After Decryption  : " + TextAfterDecryption);

            }
            public static int RandomNumber(int From, int To)
            {
                Random random = new Random();
                int randomNumber = random.Next(From, To);
                //Console.WriteLine(randomNumber);

                return randomNumber;
            }
            public static char GetRandomCharacter(enCharType Type)
            {
                char RandomCharacter = ' ';
                switch (Type)
                {
                    case enCharType.SmallLetter:

                        {
                            RandomCharacter = Convert.ToChar(RandomNumber(98, 122));
                            break;

                        }
                    case enCharType.CapitalLetter:

                        {
                            RandomCharacter = Convert.ToChar(RandomNumber(65, 90));
                            break;

                        }
                    case enCharType.SpecialCharcater:

                        {
                            RandomCharacter = Convert.ToChar(RandomNumber(33, 47));
                            break;

                        }
                    case enCharType.DigitInOrder:

                        {
                            RandomCharacter = Convert.ToChar(RandomNumber(48, 57));
                            break;

                        }

                }

                return RandomCharacter;

            }
            public static string GenerateWord(enCharType CharType, short Length)
            {
                string word = "";

                for (int i = 0; i < Length; i++)
                {
                    word += GetRandomCharacter(CharType);
                }
                return word;
            }
            public static string GenerateKey()
            {
                string Key = "";
                Key = GenerateWord(enCharType.CapitalLetter, 4) + "-";
                Key = Key + GenerateWord(enCharType.CapitalLetter, 4) + "-";
                Key = Key + GenerateWord(enCharType.CapitalLetter, 4) + "-";
                Key = Key + GenerateWord(enCharType.CapitalLetter, 4);
                return Key;
            }
            public static void GenerateKeys(short NumberOfKeys)
            {
                for (int i = 0; i < NumberOfKeys; i++)
                {
                    Console.WriteLine("Key [" + i + "] : " + GenerateKey());
                }
            }
            public static void ReadArray(int[] arr)
            {
                Console.WriteLine("Enter array elements: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Element [" + (i + 1) + "] : ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            public static int RepeatedTimes(int[] arr)
            {
                int NubmerToCheck = ReadPositiveNumber("Enter the number you want to check : ");

                int counter = 0;

                Console.Write(" Number " + NubmerToCheck);


                for (int i = 0; i < arr.Length; i++)
                {
                    if (NubmerToCheck == arr[i])
                        counter++;
                }
                return counter;
            }
            public static void PrintArray(int[] arr, int arrLength)
            {

                for (int i = 0; i < arrLength; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();

            }
            public static void FillArrayWithRandomNumbers(int[] arr, int arrLength)
            {
                // Console.WriteLine("Enter array elements: ");
                for (int i = 0; i < arrLength; i++)
                {
                    arr[i] = RandomNumber(1, 100);
                }
            }
            public static int MaxNumbersInArray(int[] arr, int arrLength)
            {
                int Number = arr[0];
                for (int i = 0; i < arrLength; i++)
                {
                    if (arr[i] > Number)
                        Number = arr[i];
                }
                return Number;
            }
            public static int MinNumbersInArray(int[] arr, int arrLength)
            {
                int Number = arr[0];
                for (int i = 0; i < arrLength; i++)
                {
                    if (arr[i] < Number)
                        Number = arr[i];
                }
                return Number;
            }
            public static int SumArray(int[] arr, int arrLength)
            {
                int Sum = 0;
                for (int i = 0; i < arrLength; i++)
                {
                    Sum += arr[i];
                }
                return Sum;
            }
            public static float ArrayAverage(int[] arr, int arrLength)
            {
                return (float)SumArray(arr, arrLength) / arrLength;
            }
            public static void CopyArray(int[] arrSource, int[] arrDestination, int arrLength)
            {
                for (int i = 0; i < arrLength; i++)
                {
                    arrDestination[i] = arrSource[i];
                }
            }
            public static void CopyArrayOnlyPrimeNumber(int[] arrSource, int[] arrDestination, int arrLength, ref int arr2Length)
            {
                for (int i = 0; i < arrLength; i++)
                {
                    if (_CheckPrime(arrSource[i]) == enPrimOrNotPtime.Prime)
                    {
                        arrDestination[arr2Length] = arrSource[i];
                        arr2Length++;
                    }

                }
            }
            public static void Sum2Arrays(int[] arr1, int[] arr2, int[] arrSum, int arrLength)
            {
                for (int i = 0; i < arrLength; i++)
                {
                    arrSum[i] = arr1[i] + arr2[i];
                }
            }
            public static void Swap(ref int Num1, ref int Num2)
            {
                int temp;
                temp = Num1;
                Num1 = Num2;
                Num2 = temp;

            }
            public static void ShuffleArray(int[] arr1, int arrLength)
            {
                for (int i = 0; i < arrLength; i++)
                {
                    Swap(ref arr1[i], ref arr1[i + 1]);

                }
            }
            public static void ReservedArray(int[] arrSource, int[] arrDestination, int arrLength)
            {
                int counter = 0;
                for (int i = arrLength - 1; i >= 0; i--)
                {
                    arrDestination[counter] = arrSource[i];
                    counter++;
                }
            }
            public static void FillArrayWithKays(string[] arr, int arrLength)
            {
                for (int i = 0; i < arrLength; i++)
                {
                    arr[i] = GenerateKey();
                }
            }
            public static void PrintStringArray(string[] arr, int arrLength)
            {

                for (int i = 0; i < arrLength; i++)
                {
                    Console.WriteLine("Array [" + i + "] : " + arr[i]);
                }

            }
            public static int FindNumberPositionInArray(int[] arr, int arrLength, int Number)
            {
                for (int i = 0; i < arrLength; i++)
                {
                    if (arr[i] == Number)
                    {
                        return i;
                    }
                }
                return -1;
            }
            public static bool IsNumberInArray(int[] arr, int arrLength, int Number)
            {
                return (FindNumberPositionInArray(arr, arrLength, Number) != -1);

            }
            public static void AddArrayElement(int Number, int[] arr, ref int arrLength)
            {
                arrLength++;
                arr[arrLength - 1] = Number;
            }
            public static void InputUserElementInArray(int[] arr, ref int arrLength)
            {
                bool AddMore = true;
                do
                {

                    AddArrayElement(ReadPositiveNumber("Please enter number? "), arr, ref arrLength);

                    Console.Write("Do you want to add more numbers ?No:{0},yes:{1}?");
                    AddMore = Console.ReadLine() == "1";
                }
                while (AddMore);
            }
            public static void FillArrayUsingAddArrayElement(int[] arrSource, int arrLength)
            {
                // Console.WriteLine("Enter array elements: ");
                for (int i = 0; i < arrLength; i++)
                {
                    arrSource[i] = RandomNumber(1, 100);
                }
            }
            public static void CopyArray(int[] arrSource, int[] arrDestination, int arrLength, ref int arrDestinationLength)
            {
                for (int i = 0; i < arrLength; i++)
                {
                    AddArrayElement(arrSource[i], arrDestination, ref arrDestinationLength);
                }
            }
            public static void CopyOddNumbers(int[] arrSource, int[] arrDestination, int arrLength, ref int arrDestinationLength)
            {
                for (int i = 0; i < arrLength; i++)
                {
                    if (arrSource[i] % 2 != 0)
                        AddArrayElement(arrSource[i], arrDestination, ref arrDestinationLength);
                }
            }
            public static void CopyPrimeNumbers(int[] arrSource, int[] arrDestination, int arrLength, ref int arrDestinationLength)
            {
                for (int i = 0; i < arrLength; i++)
                {
                    if (_CheckPrime(arrSource[i]) == enPrimOrNotPtime.Prime)
                        AddArrayElement(arrSource[i], arrDestination, ref arrDestinationLength);
                }
            }
            public static void CopyDistinctNumbersToArray(int[] arrSource, int[] arrDestination, int arrLength, ref int arrDestinationLength)
            {
                for (int i = 0; i < arrLength; i++)
                {
                    if (!IsNumberInArray(arrDestination, arrDestinationLength, arrSource[i]))
                        AddArrayElement(arrSource[i], arrDestination, ref arrDestinationLength);
                }
            }
            public static bool isPalindromeArray(int[] arr, int Length)
            {
                for (int i = 0; i < Length; i++)
                {
                    if (arr[i] != arr[Length - i - 1])
                        return false;

                }
                return true;
            }
            public static int CountOddNumbers(int[] arr, int arrLength)
            {
                int counter = 0;
                for (int i = 0; i < arrLength; i++)
                {
                    if (arr[i] % 2 != 0)
                        counter++;
                }
                return counter;
            }
            public static int CountEvenNumbers(int[] arr, int arrLength)
            {
                int counter = 0;
                for (int i = 0; i < arrLength; i++)
                {
                    if (arr[i] % 2 == 0)
                        counter++;
                }
                return counter;
            }
            public static void FillArrayWithRandomNagitveAndPositiveNumbers(int[] arr, int arrLength)
            {
                // Console.WriteLine("Enter array elements: ");
                for (int i = 0; i < arrLength; i++)
                {
                    arr[i] = RandomNumber(-100, 100);
                }
            }
            public static int CountPositiveNumbers(int[] arr, int arrLength)
            {
                int counter = 0;
                for (int i = 0; i < arrLength; i++)
                {
                    if (arr[i] >= 0)
                        counter++;
                }
                return counter;
            }
            public static int CountNegativeNumbers(int[] arr, int arrLength)
            {
                int counter = 0;
                for (int i = 0; i < arrLength; i++)
                {
                    if (arr[i] <= 0)
                        counter++;
                }
                return counter;
            }
            public static float ReadNumber()
            {
                float Num;
                Console.WriteLine("Please enter a number?");
                Num = Convert.ToSingle(Console.ReadLine());
                return Num;
            }
            public static float MyABS(float Number)
            {
                if (Number > 0)
                    return Number;
                else
                    return Number * -1;
            }
            public static float GetFractionPart(float Number)
            {
                return Number - (int)Number;
            }
            public static int MyRound(float Number)
            {
                int intPart;
                intPart = (int)Number;

                float FractionPart = GetFractionPart(Number);
                if (MyABS(FractionPart) >= .5)

                {
                    if (Number > 0)

                        return ++intPart;
                    else
                        return --intPart;
                }
                else
                {
                    return intPart;
                }
            }
            public static int MyFloor(float Number)
            {

                if (Number > 0)

                    if (Number > 0)
                        return (int)Number;

                return (int)(Number - 1);


            }
            public static int MyCeil(float Number)
            {
                if (MyABS(GetFractionPart(Number)) > .0)
                {
                    if (Number > 0)
                        return (int)(Number) + 1;
                    else
                        return (int)(Number);
                }
                else
                    return (int)(Number);


            }
            public static int MySqut(float Number)
            {
                return (int)(Math.Pow(Number, 0.5));
            }
            static void Main(string[] args)
            {
                //PrintMultiPrintMultiplicationTable();
                //PrintPrimeNumbersFrom1ToN(ReadPositiveNumber("Enter Positive Number: "));
                //PrintDigets(ReadPositiveNumber("Enter Positive Number: "));
                //SumOfDigets(ReadPositiveNumber("Enter Positive Number: "));
                //PrintAllDigitFrequency(ReadPositiveNumber("Enter Positive Number: "));
                //PrintDigets(RevrseNumber(ReadPositiveNumber("Enter Positive Number: ")));
                // Console.WriteLine(isPalindromeNumber(ReadPositiveNumber("please Enter the Main Number? ")) ?
                //   "Yes,it is a Palindrome number." : "No,it is Not Palindrome number.");
                //PrintInvertedNumbersPatter(ReadPositiveNumber("Enter Positive Number: "));
                //PrintNumbersPatter(ReadPositiveNumber("Enter Positive Number: "));
                //PrintInvertedlettersPatter(ReadPositiveNumber("Enter Positive Number: "));
                // PrintlettersPatter(ReadPositiveNumber("Enter Positive Number: "));
                //PrintWordsFromAAAToZZZ();
                //PrintEncryptTextAndDecryptText();
                //RandomNumber(1, 10);
                //Console.WriteLine(GetRandomCharacter(enCharType.SmallLetter));
                //Console.WriteLine(GetRandomCharacter(enCharType.CapitalLetter));
                //Console.WriteLine(GetRandomCharacter(enCharType.SpecialCharcater));
                //Console.WriteLine(GetRandomCharacter(enCharType.DigitInOrder));
                //  GenerateKeys((short)ReadPositiveNumber("Pleaes enter how many keys to generate?"));

                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //int[] arr = new int[Lenght ];
                //ReadArray(ref arr);
                //Console.WriteLine("Original array: ");
                //PrintArray(arr,Lenght);
                //int Repeated = RepeatedTimes( arr);
                //Console.Write(" Is Repeated " + Repeated + " Time(s)");

                //int[] arr = new int[100];
                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //FillArrayWithRandomNumbers( arr, Lenght);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arr, Lenght);

                //int[] arr = new int[100];
                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //FillArrayWithRandomNumbers( arr, Lenght);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arr, Lenght);
                //Console.WriteLine("Max Number is: " + MaxNumbersInArray(arr,Lenght));

                //int[] arr = new int[100];
                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //FillArrayWithRandomNumbers( arr, Lenght);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arr, Lenght);
                //Console.WriteLine("Min Number is: " + MinNumbersInArray(arr, Lenght));

                //int[] arr = new int[100];
                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //FillArrayWithRandomNumbers( arr, Lenght);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arr, Lenght);
                //Console.WriteLine("Sum of all Number is: " + SumArray(arr, Lenght));


                //int[] arr = new int[100];
                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //FillArrayWithRandomNumbers( arr, Lenght);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arr, Lenght);
                //Console.WriteLine("Average of all Number is: " + ArrayAverage(arr, Lenght));


                //int[] arrSource = new int[100];
                //int[] arrDestination = new int[100];
                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //FillArrayWithRandomNumbers( arrSource, Lenght);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arrSource, Lenght);
                //CopyArray(arrSource,  arrDestination, Lenght);
                //Console.WriteLine("Array2 Element After Copy: ");
                //PrintArray(arrDestination, Lenght);


                //int[] arrSource = new int[100];
                //int[] arrDestination = new int[100];
                //int Lenght1 = ReadPositiveNumber("Enter Number Of Element: ");
                //int Lenght2 = 0;
                //FillArrayWithRandomNumbers( arrSource, Lenght1);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arrSource, Lenght1);
                //CopyArrayOnlyPrimeNumber(arrSource,  arrDestination, Lenght1,ref Lenght2);
                //Console.WriteLine("Prime Number in array2 is: ");
                //PrintArray(arrDestination, Lenght2);

                //int[] arr1 = new int[100];
                //int[] arr2 = new int[100];
                //int[] sumArray= new int[100];
                //int Lenght1 = ReadPositiveNumber("Enter Number Of Element: ");
                //FillArrayWithRandomNumbers( arr1, Lenght1);
                //FillArrayWithRandomNumbers( arr2, Lenght1);
                //Console.WriteLine("Array1 Element: ");
                //PrintArray(arr1, Lenght1);
                //Console.WriteLine("Array2 Element: ");
                //PrintArray(arr2, Lenght1);
                //Sum2Arrays(arr1,  arr2,ref sumArray, Lenght1);
                //Console.WriteLine("Sum Of array1 and array2 element: ");
                //PrintArray(sumArray, Lenght1);

                //int[] arr1 = new int[100];
                //int Lenght1 = ReadPositiveNumber("Enter Number Of Element: ");
                //FillArrayWithRandomNumbers( arr1, Lenght1);
                //Console.WriteLine("Array1 Element: ");
                //PrintArray(arr1, Lenght1);
                //ShuffleArray( arr1, Lenght1);
                //Console.WriteLine("Array element after Shuffle: ");
                //PrintArray(arr1, Lenght1);

                //int[] arrSource = new int[100];
                //int[] arrDestination = new int[100];
                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //FillArrayWithRandomNumbers( arrSource, Lenght);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arrSource, Lenght);
                //ReservedArray(arrSource,  arrDestination, Lenght);
                //Console.WriteLine("Array2 Element After Reserved: ");
                //PrintArray(arrDestination, Lenght);

                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //string[] arr = new string[Lenght];
                //FillArrayWithKays( arr, Lenght);
                //PrintStringArray(arr, Lenght);

                //int[] arrSource = new int[100];
                //int[] arrDestination = new int[100];
                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //FillArrayWithRandomNumbers(arrSource, Lenght);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arrSource, Lenght);
                //int Number = ReadPositiveNumber("Please enter a number to search for ?  ");
                //Console.WriteLine("Number you are looking for is:" + Number );
                //int NumberPosition =FindNumberPositionInArray(arrSource, Lenght, Number);
                //if (NumberPosition != -1)
                //{
                //    Console.WriteLine("The Number Found at position:" + NumberPosition);
                //    Console.WriteLine("The Number Found its order:" + (NumberPosition + 1));
                //}
                //else
                //    Console.WriteLine("The Number is not found:-(");

                //int[] arrSource = new int[100];
                //int[] arrDestination = new int[100];
                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //FillArrayWithRandomNumbers(arrSource, Lenght);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arrSource, Lenght);
                //int Number = ReadPositiveNumber("Please enter a number to search for ?  ");
                //Console.WriteLine("Number you are looking for is:" + Number);
                //int NumberPosition = FindNumberPositionInArray(arrSource, Lenght, Number);
                //if (!IsNumberInArray(arrSource, Lenght, Number))
                //    Console.WriteLine("No, The Number is not found:-(");
                //else
                //    Console.WriteLine("yes, The Number is found:-");

                //int[] arrSource = new int[100];
                //int Lenght = 0;
                //InputUserElementInArray(arrSource, ref Lenght);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arrSource, Lenght);

                //int[] arrSource = new int[100];
                //int[] arrDestination = new int[100];
                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //int Lenght2 = 0;
                //FillArrayWithRandomNumbers(arrSource, Lenght);
                //CopyArray(arrSource, arrDestination, Lenght, ref Lenght2);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arrSource, Lenght);
                //Console.WriteLine("Array2 Element After Copy: ");
                //PrintArray(arrDestination, Lenght2);

                //int[] arrSource = new int[100];
                //int[] arrDestination = new int[100];
                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //int Lenght2 = 0;
                //FillArrayWithRandomNumbers(arrSource, Lenght);
                //CopyOddNumbers(arrSource, arrDestination, Lenght, ref Lenght2);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arrSource, Lenght);
                //Console.WriteLine("Array2 Odd numbers: ");
                //PrintArray(arrDestination, Lenght2);

                //int[] arrSource = [10,10,10,10,70,70,50,90,70,50];
                //int[] arrDestination = new int[100];
                //int Lenght = 10;
                //int Lenght2 = 0;
                //CopyDistinctNumbersToArray(arrSource, arrDestination, Lenght, ref Lenght2);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arrSource, Lenght);
                //Console.WriteLine("Array 2 distinct elements: ");
                //PrintArray(arrDestination, Lenght2);

                //int[] arrSource = [10, 20,30,30,20,10];
                //int[] arrDestination = new int[100];
                //int Lenght = 6;
                //Console.WriteLine("Array Element: ");
                //PrintArray(arrSource, Lenght);
                //if (!isPalindromeArray(arrSource, Lenght))
                //    Console.WriteLine("No,Array is Not Palindrome.");
                //else
                //    Console.WriteLine("Yes,Array is  Palindrome.");

                //int[] arrSource = new int[100];
                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //FillArrayWithRandomNumbers(arrSource, Lenght);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arrSource, Lenght);
                //Console.WriteLine("Odd numbers count is : "+ CountOddNumbers(arrSource, Lenght));

                //int[] arrSource = new int[100];
                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //FillArrayWithRandomNumbers(arrSource, Lenght);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arrSource, Lenght);
                //Console.WriteLine("Even numbers count is : " + CountEvenNumbers(arrSource, Lenght));

                //int[] arrSource = new int[100];
                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //FillArrayWithRandomNagitveAndPositiveNumbers(arrSource, Lenght);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arrSource, Lenght);
                //Console.WriteLine("Positive numbers count is : " + CountPositiveNumbers(arrSource, Lenght));

                //int[] arrSource = new int[100];
                //int Lenght = ReadPositiveNumber("Enter Number Of Element: ");
                //FillArrayWithRandomNagitveAndPositiveNumbers(arrSource, Lenght);
                //Console.WriteLine("Array Element: ");
                //PrintArray(arrSource, Lenght);
                //Console.WriteLine("Negative numbers count is : " + CountNegativeNumbers(arrSource, Lenght));

                //float Number = ReadNumber();
                //Console.WriteLine("My abs Result:" + MyABS(Number));
                //Console.WriteLine("C# abs Result:" + Math.Abs(Number));

                //float Number = ReadNumber();
                //Console.WriteLine("My abs Result:" + MyABS(Number));
                //Console.WriteLine("C# abs Result:" + Math.Abs(Number));

                //float Number = ReadNumber();
                //Console.WriteLine("My round Result:" + MyRound(Number));
                //Console.WriteLine("C# round Result:" + Math.Round(Number));

                //float Number = ReadNumber();
                //Console.WriteLine("My floor Result:" + MyFloor(Number));
                //Console.WriteLine("C# floor Result:" + Math.Floor(Number));

                //float Number = ReadNumber();
                //Console.WriteLine("My ceil  Result:" + MyCeil(Number));
                //Console.WriteLine("C# ceil  oor Result:" + Math.Ceiling(Number));

                float Number = ReadNumber();
                Console.WriteLine("My Sqrt  Result:" + MySqut(Number));
                Console.WriteLine("C# Sqrt  oor Result:" + Math.Sqrt(Number));
            }
        }

    }
}
