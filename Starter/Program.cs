using System;
/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/
/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.88   A       92 (3.68 pts)

*/
// initialize variables - graded assignments 
String[] StudentNames = new String[] {"Sophia", "Andrew", "Emma", "Logan"};

int[] sophiaScore = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScore = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScore = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScore = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

int currentAssignments = 5;
int extraCreditAssignments = 0;

decimal sophiaAverageScore = 0;
decimal andrewAverageScore = 0;
decimal emmaAverageScore = 0;
decimal loganAverageScore = 0;
decimal sumExtraCreditScore = 0;
decimal currentExtraCreditScore = 0;
decimal overalGrade = 0;


static string GetGrade(decimal score){
    string grade;
    if(score >= 97 && score < 101){
        grade = "A+";
    } else if(score >= 93 && score < 97){
        grade = "A";
    } else if (score >= 90 && score < 93){
        grade = "A-";
    } else if(score >= 87 && score < 90){
        grade = "B+";
    } else if(score >= 83 && score < 87){
        grade = "B";
    } else if(score >= 80 && score < 83){
        grade = "B-";
    } else if(score >= 77 && score < 80){
        grade = "C+";
    } else if(score >= 73 && score < 77){
        grade = "C-";
    } else if(score >= 70 && score < 73){
        grade = "C";
    } else if(score >= 67 && score < 70){
        grade = "D+";
    } else if(score >= 63 && score < 67){
        grade = "D";
    } else if(score >= 60 && score < 63){
        grade = "D-";
    } else if(score >= 0 && score < 60){
        grade = "F";
    } else {
        grade = "Oops, something went wrong...";
    }
    return grade;
}

Console.WriteLine("Student\t\tExam Score\t\tOverall Grade\t\tExtra Credit");

foreach(string name in StudentNames){
    switch(name){
        case "Sophia":
            for(int i = 0; i< sophiaScore.Length; i++){ 
                if(i < currentAssignments){
                    sophiaSum = sophiaSum + sophiaScore[i];
                }
                else if (sophiaScore.Length >= currentAssignments){
                    extraCreditAssignments += 1;
                    sumExtraCreditScore += sophiaScore[i];
                }
            }
            sophiaAverageScore = (decimal)sophiaSum / currentAssignments;
            currentExtraCreditScore = (decimal)(sumExtraCreditScore)/extraCreditAssignments;
            overalGrade = (decimal)((decimal)sophiaSum + ((decimal)sumExtraCreditScore/10))/currentAssignments;
            Console.WriteLine($"{name}:\t\t{sophiaAverageScore}\t\t\t{overalGrade}\t{GetGrade(overalGrade)}\t\t\t{currentExtraCreditScore}");
            extraCreditAssignments = 0;
            sumExtraCreditScore = 0;
            break;
        case "Andrew":
             for(int i = 0; i< andrewScore.Length; i++){ 
                if(i < currentAssignments){
                    andrewSum = andrewSum + andrewScore[i];
                }
                else if (andrewScore.Length >= currentAssignments){
                    extraCreditAssignments += 1;
                    sumExtraCreditScore += andrewScore[i];
                }
            }
            andrewAverageScore = (decimal)andrewSum / currentAssignments;
            currentExtraCreditScore = (decimal)(sumExtraCreditScore)/extraCreditAssignments;
            overalGrade = (decimal)((decimal)andrewSum + ((decimal)sumExtraCreditScore/10))/currentAssignments;
            Console.WriteLine($"{name}:\t\t{andrewAverageScore}\t\t\t{overalGrade}\t{GetGrade(overalGrade)}\t\t\t{currentExtraCreditScore}");
            extraCreditAssignments = 0;
            sumExtraCreditScore = 0;
        break;
        case "Emma":
            for(int i = 0; i< emmaScore.Length; i++){ 
                if(i < currentAssignments){
                    emmaSum = emmaSum + emmaScore[i];
                }
                else if (emmaScore.Length >= currentAssignments){
                    extraCreditAssignments += 1;
                    sumExtraCreditScore += emmaScore[i];
                }
            }
            emmaAverageScore = (decimal)emmaSum / currentAssignments;
            currentExtraCreditScore = (decimal)(sumExtraCreditScore)/extraCreditAssignments;
            overalGrade = (decimal)((decimal)emmaSum + ((decimal)sumExtraCreditScore/10))/currentAssignments;
            Console.WriteLine($"{name}:\t\t{emmaAverageScore}\t\t\t{overalGrade}\t{GetGrade(overalGrade)}\t\t\t{currentExtraCreditScore}");
            extraCreditAssignments = 0;
            sumExtraCreditScore = 0;
            break;
        case "Logan":
            for(int i = 0; i< loganScore.Length; i++){ 
                if(i < currentAssignments){
                    loganSum = loganSum + loganScore[i];
                }
                else if (loganScore.Length >= currentAssignments){
                    extraCreditAssignments += 1;
                    sumExtraCreditScore += loganScore[i];
                }
            }
            loganAverageScore = (decimal)loganSum / currentAssignments;
            currentExtraCreditScore = (decimal)(sumExtraCreditScore)/extraCreditAssignments;
            overalGrade = (decimal)((decimal)loganSum + ((decimal)sumExtraCreditScore/10))/currentAssignments;
            Console.WriteLine($"{name}:\t\t{loganAverageScore}\t\t\t{overalGrade}\t{GetGrade(overalGrade)}\t\t\t{currentExtraCreditScore}");
            extraCreditAssignments = 0;
            sumExtraCreditScore = 0;
            break;
        default:
            break;
    }
}

Console.WriteLine("Press Enter to continue.");
