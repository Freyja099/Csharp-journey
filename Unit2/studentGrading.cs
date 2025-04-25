using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
string[] students = { "Sophia", "Andrew", "Emma", "Logan" };

int[] Sophia = { 90, 86, 87, 98, 100 , 94 , 90 };
int[] Andrew = { 92, 89, 81, 96, 90 , 89};
int[] Emma = { 90, 85, 87, 98, 68 , 89 , 89 , 89 };
int[] Logan = { 90, 95, 87, 88, 96 , 96};


int[] scores = new int[5];

foreach( string student in students){
    string currentName = student;

    if(student == "Sophia"){
        scores = Sophia;
    }
    else if(student == "Andrew"){
        scores = Andrew;
    }
    else if(student == "Emma"){
        scores = Emma;
    }
    else if(student == "Logan"){
        scores = Logan;
    }

    int counter=0;

    int assignedScore = 0;
    foreach(int score in scores){
        counter++;
        if (counter <= currentAssignments){
            assignedScore += score;
        }
        else 
            assignedScore += score / 10;
        
    }

    decimal currentScore = (decimal)assignedScore / currentAssignments;
    char gradeLetter =  ' ';
    char gradeSymbol = ' ';

    if ((int)currentScore >= 80 && (int)currentScore <= 89){
        gradeLetter = 'B';
        
        if (currentScore < 83)
            gradeSymbol = '-';
        else if (currentScore < 87)
            gradeSymbol = ' ';
        
        else if (currentScore >= 87)
            gradeSymbol = '+';
    }

    if ( (int)currentScore > 89 && (int)currentScore <100){
       gradeLetter = 'A';
        
        if (currentScore < 93)
            gradeSymbol = '-';
        else if (currentScore < 97)
            gradeSymbol = ' ';
        else if (currentScore >= 97)
            gradeSymbol = '+';
    }

   

    Console.WriteLine($"{currentName}:\t\t {currentScore} \t {gradeLetter}{gradeSymbol}");

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
