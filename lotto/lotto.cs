using System;
using static System.Console;

namespace lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6개의 숫자 입력받기
            WriteLine("1~45 중에서 서로 다른 숫자 6개를 입력하세요. 하나씩 입력할 때마다 엔터를 누르면 됩니다.");
            int[] inputList = new int[6];
            for (int i = 0; i < 6; i++)
            {
                //string input = ReadLine();
                //int inputToInt = int.Parse(ReadLine());
                inputList[i] = int.Parse(ReadLine());

                //if (!(0 < inputToInt && inputToInt <= 45))
                //{
                //    WriteLine("1부터 45 사이의 숫자를 입력해야 합니다. 다시 입력하세요: ");
                //    input = ReadLine();
                //    inputToInt = int.Parse(ReadLine());
                //    inputList[i] = inputToInt;
                //}
                //else if (inputToInt == inputList[i])
                //{
                //    WriteLine("중복된 번호입니다. 다시 입력하세요.");
                //    input = ReadLine();
                //    inputToInt = int.Parse(ReadLine());
                //    inputList[i] = inputinputList[i] = inputToInt;ToInt;
                //}
                //else {
                //    inputList[i] = inputToInt;
                //}

            }

            // 로또 당첨 번호 - 랜덤 6개의 숫자 생성하기
            int[] ranNumList = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Random myObject = new Random();
                ranNumList[i] = myObject.Next(1, 45);
            }

            // 로또 당첨 번호 출력
            Write("이번 로또 당첨 번호는: ");
            for (int i = 0; i < 6; i++)
            {
                Write(ranNumList[i] + " ");
            }
            WriteLine("입니다!");

            // 숫자 비교하기
            int score = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (ranNumList[i] == inputList[j])  //ranNumList[i] == input2 || ranNumList[i] == input3 || ...
                    {
                        score += 1;
                    }
                    else
                    {
                    }
                }
            }

            // 맞춘 갲수 출력
            WriteLine("숫자를 " + score + "개 맞췄습니다.");

            // 등수 출력
            int grade = 0;
            switch (score)
            {
                case 1:
                    WriteLine("아쉽지만 꽝입니다. 다시 도전해보세요!");
                    break;
                case 2:
                    WriteLine("아쉽지만 꽝입니다. 다시 도전해보세요!");
                    break;
                case 3:
                    grade = 4;
                    WriteLine("축하합니다! " + grade + "등입니다.");
                    break;
                case 4:
                    grade = 3;
                    WriteLine("축하합니다! " + grade + "등입니다.");
                    break;
                case 5:
                    grade = 2;
                    WriteLine("축하합니다! " + grade + "등입니다.");
                    break;
                case 6:
                    grade = 1;
                    WriteLine("축하합니다! " + grade + "등입니다.");
                    break;
            }

        }
    }
}