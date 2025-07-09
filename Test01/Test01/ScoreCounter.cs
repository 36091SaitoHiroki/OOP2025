namespace Test01 {
    public class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);

        }

         
        public static IEnumerable<Student> ReadScore(string filePath) {
            
            var Scores = new List<Student>();
            
            var lines = File.ReadAllLines(filePath);
            
            foreach (var line in lines) {
                string[] items = line.Split(',');
                
                Student student = new Student() {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2]),
                };
                Scores.Add(student);
            }
            return Scores;
        }

        //メソッドの概要： 
        public IDictionary<string?, int> GetPerStudentScore() {
            var dict = new Dictionary<string?, int>();
            foreach (Student student in _score) {
                if (dict.ContainsKey(student.Name))

                    dict[student.Name] += student.Score;
                else
                    dict[student.Name] = student.Score;
            }
            return dict;
        }
    }
}
