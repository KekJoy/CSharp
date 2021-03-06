namespace GameOfLife
{
    /* Реализуйте игру в жизнь на прямоугольном конечном поле.
     
     На каждом ходе клетка меняет свое состояние по таким правилам:
     1. Если у нее менее 2 живых соседей или более трех живых — она становится мертвой (false).
     2. Если ровно 3 живых соседа, то клетка становится живой (true)
     3. Если ровно 2 живых соседа, то клетка сохраняет своё состояние.

     У каждой неграничной клетки есть 8 соседей (в том числе по диагонали)

    Работу над игрой постройте итеративно в стиле TDD:
        1. Сначала напишите какой-нибудь простейший тест в соседнем файле GameTest.cs. Тест должен быть красным.
        То есть должен проверять ещё нереализованное требование.
        2. Только потом напшишите простейшую реализацию, которая делает тест зеленым. 
        Не старайтесь реализовать всю логику, просто сделайте тест зеленым как можно быстрее.
        3. Повторяйте процесс, пока ещё можете придумать новые красные тесты.

     На каждый шаг (тест и реализация) у вас должно уходить не более 5 минут.
     Если вы не успели поднять тест за 5 минут — удалите этот тест и придумайте тест попроще.
     Засекайте время таймером на телефоне.

     Начните с простейших тестов. 

     Проект настроен так, что при каждой сборке запускаются все тесты и отчет выводится в консоль
    */
    public class Game
    {
        public static bool[,] NextStep(bool[,] field) // i = x n = y
        {
            bool[,] oldArray = field;
            int xMax = oldArray.GetLength(0);
            int yMax = oldArray.GetLength(1);
            bool[,] substrate = new bool[3, 3] {{ false, false, false }, { false, false, false }, { false, false, false }};
            int counter = 0;
            for(int i = 1; i <= xMax; i++)
            {
                for (int n = 1; n <= yMax; n++)
                {
                    if (oldArray[i -1 , n -1] == true) counter++; // выход за пределы i
                    if (oldArray[i , n -1 ] == true) counter++; // выход за пределы n
                    if (oldArray[i +1 , n -1  ] == true) counter++; // 
                    if (oldArray[i+1 , n] == true) counter++;
                    if (oldArray[i +1 , n +1 ] == true) counter++;
                    if (oldArray[i , n +1 ] == true) counter++;
                    if (oldArray[i -1  , n + 1] == true) counter++;
                    if (oldArray[i -1 , n ] == true) counter++;
                } 
            }
            field = newArray;
            return field;
        }

        public static che
    }
}