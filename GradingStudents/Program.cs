

static List<int> gradingStudents(List<int> grades) {
    //create empty list result and new grade
    int newGrade = 0;
    var result = new List<int>();
    //for each grade in grades
    foreach (int grade in grades) {
        //if less than 38 add grade to result
        if (grade < 38) {
            result.Add(grade);
            continue;
        }
        //find next multiple of 5 above grade

        for (int i = 100; i >= grade; i -= 5) {
            //if multiple - grade less than 3, grade becomes multiple
            //if grade between i-5 and i
            if ((i - 5) <= grade && grade <= i) {
                if (i - grade < 3) {
                    newGrade = i;
                    result.Add(newGrade);
                    continue;
                }
                //else return grade to result
                else {
                    result.Add(grade);
                    break;
                }
            }
        }
    }
    //return final result
    result.ForEach(x => Console.WriteLine(x));
    return result;
}

List<int> test = new List<int>() {37,40};
gradingStudents(test);


   








