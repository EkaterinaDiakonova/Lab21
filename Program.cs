using System.Collections.Generic;

// List<string> tasks = new List<string> {"Код", "Тест", "код"};
// tasks.Add("Отчёт");
// Console.WriteLine(tasks.Count);

// bool InsertTaskSafe(List<string> tasks, int index, string title)
// {
//     if (index < 0 || index > tasks.Count)
//     {
//         return false;
//     }

//     tasks.Insert(index, title);
//     return true;
// }

// List<string> emptyTasks = new List<string>();
// emptyTasks.Add("Код");
// Console.WriteLine(tasks.Count);

// List<string> tasks = new List<string> {"Код", "Тест", "код"};
// tasks.Add("Отчёт");
// Console.WriteLine(tasks.Count);
// Console.WriteLine(tasks[0]);
// Console.WriteLine(tasks[tasks.Count - 1]);

// List<string> editableTasks = new List<string> { "Черновик" };
// editableTasks[0] = "Готово";
// Console.WriteLine(editableTasks[0]);
// Console.WriteLine(editableTasks.Count);

// List<string> tasks = new List<string> {"Код", "Тест", "код"};
// tasks.Add("Отчёт");
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


// List<string> removedTasks = new List<string> { "Код", "Тест", "Код" };

// bool removed = removedTasks.Remove("Код");
// Console.WriteLine(removed);
// PrintTasks(removedTasks);
// Console.WriteLine(removedTasks.Remove("Экзамен"));
// Console.WriteLine(removedTasks.Count);

List<string> removedTasks = new List<string> { "Код", "Тест", "Код" };

bool removed = removedTasks.Remove("Код");
removedTasks.RemoveAt(1);
PrintTasks(removedTasks);