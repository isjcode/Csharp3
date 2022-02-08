using System;

namespace Task {
   class Task3 {
      static void Main(string[] args) {
      }

        #region task1
            static int Biggest(int [] arr) {
                int biggest = arr[0];

                for (int i = 1; i < arr.Length; i++) {
                    if (arr[i] > biggest) {
                        biggest = arr[i];
                    }
                }

                return biggest;
            }
        #endregion

        #region task2
            static int task2() {
                string n = Console.ReadLine();
                int value = 0;
                while (!int.TryParse(n, out value)) {
                    Console.WriteLine("Not an integer.");
                    n = Console.ReadLine();
                }
                int sum = 0;
                while (value > 0) {
                    sum += value % 10;
                    value = (int) value / 10;
                }

                return sum;
            }
        #endregion
        #region task3
            static double task3(double n1, double n2, double n3) {
                double [] arr = {n1, n2, n3};

                Array.Sort(arr);

                return arr[1] + arr[2];
            }
        #endregion


   }
}