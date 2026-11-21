using System.Collections.Generic;

// bool InsertTaskSafe(List<string> tasks, int index, string title)
// {
//     if (index < 0 || index > tasks.Count)
//     {
//         return false;
//     }

//     tasks.Insert(index, title);
//     return true;
// }

// void PrintTasks(List<string> tasks)
// {
//     if (tasks.Count == 0)
//     {
//         Console.WriteLine("Список пуст");
//         return;
//     }

//     for (int i = 0; i < tasks.Count; i++)
//     {
//         Console.WriteLine($"{i}: {tasks[i]}");
//     }
// }
// PrintTasks(tasks);

// bool RemoveTaskAtSafe(List<string> tasks, int index)
// {
//     if (index < 0 || index >= tasks.Count) 
//     {
//         return false; 
//     }
//     tasks.RemoveAt(index); 
//     return true; 
// }

// Console.Write("Сколько задач добавить сначала: ");
// int count = Convert.ToInt32(Console.ReadLine());

// List<string> tasks = new List<string>();

// for (int i = 0; i < count; i++)
// {
//     Console.Write($"Задача {i + 1}: ");
//     string title = Console.ReadLine() ?? "";
//     tasks.Add(title);
// }
// Console.WriteLine("1. Исходный список:");
// PrintTasks(tasks);

// Console.Write("Введите задачу для добавления в конец: ");
// string newTask = Console.ReadLine() ?? "";
// tasks.Add(newTask);
// Console.WriteLine("Задача добавлена.");

// Console.Write("Введите задачу для вставки: ");
// string insertTask = Console.ReadLine() ?? "";
// Console.Write("Введите индекс для вставки: ");
// int insertIndex = Convert.ToInt32(Console.ReadLine());

// bool insertResult = InsertTaskSafe(tasks, insertIndex, insertTask);

// if (insertResult) 
// {
//     Console.WriteLine("Задача вставлена.");
// }
// else 
// {
//     Console.WriteLine("Недопустимый индекс вставки.");
// }

// Console.Write("Введите название задачи для удаления: ");
// string removeTask = Console.ReadLine() ?? "";

// if (tasks.Remove(removeTask)) 
// {
//     Console.WriteLine("Первое совпадение удалено.");
// }
// else
// {
//     Console.WriteLine("Задача не найдена.");
// }

// Console.Write("Введите индекс задачи для удаления: ");
// int removeIndex = Convert.ToInt32(Console.ReadLine());
// bool removeResult = RemoveTaskAtSafe(tasks, removeIndex);

// if (removeResult)
// {
//     Console.WriteLine("Задача по индексу удалена.");
// }
// else
// {
//     Console.WriteLine("Недопустимый индекс удаления.");
// }

// Console.Write("Введите название задачи для поиска: ");
// string searchTask = Console.ReadLine() ?? "";
// int index = tasks.IndexOf(searchTask);
// if (index != -1)
// {
//     Console.WriteLine($"Первый индекс: {index}");
// }
// else
// {
//     Console.WriteLine("Задача не найдена.");
// }
// Console.WriteLine(">>> Итоговый список дел <<<");
// Console.WriteLine($"Количество задач: {tasks.Count}");
// PrintTasks(tasks);

List<string> testList = new List<string> {"Код", "Тест", "Код" };
int CountTask(List<string> tasks, string title)
{
    int count = 0;
    foreach (string task in tasks)
    {
        if (task == title)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine($"{CountTask(testList,"Код")}");
Console.WriteLine($"{CountTask(testList,"код")}");
Console.WriteLine($"{CountTask(testList,"План")}");
Console.WriteLine($"{CountTask(testList,"")}");