using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_67_2018
{
    class ExerciseResults
    {
        

        public int Id { get; set; }
        public string StundentName { get; set; }
        public int Points { get; set; }
        public string IndexNumber { get; set; }



        public ExerciseResults(int id, string stundentName, string indexNumber, int points)
        {
            Id = id;
            StundentName = stundentName;
            Points = points;
            IndexNumber = indexNumber;
        }

        public ExerciseResults()
        {
        }
    }
    
}
