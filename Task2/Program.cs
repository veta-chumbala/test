﻿Console.Write("Введите номер от 1 до 7 для определения дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1) Console.Write("Это понедельник");
if (num == 2) Console.Write("Это вторник");
if (num == 3) Console.Write("Это среда");
if (num == 4) Console.Write("Это четверг");
if (num == 5) Console.Write("Это пятница");
if (num == 6) Console.Write("Это суббота");
if (num == 7) Console.Write("Это воскресенье");
if (num !=1 && num !=2 && num !=3 && num !=4 && num !=5 && num !=6 && num !=7) Console.Write("Нет такого дня. В неделе только семь дней.");