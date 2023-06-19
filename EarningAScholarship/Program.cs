/* Students should have at least 95% attendance and an average score of 80 to win a scholarship. 
Write a profram to take student attendance and average scores values as input and output "Accepted" 
if the given requirements are satisfied, and "denied", if they are not.
Sample Input:
98
70
Sample Output:
Denied               */
Console.WriteLine("What is the attendance?");
int attendance = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the average score?");
int averageScore = Convert.ToInt32(Console.ReadLine());
if (attendance >= 95 && averageScore >= 80)
{
    Console.WriteLine("Accepted");
}
else
{
    Console.WriteLine("Denied");
}
Console.WriteLine("Press any key to exit");
Console.ReadKey();