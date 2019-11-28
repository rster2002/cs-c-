namespace Opdracht1 {
    class Subject {
        public string subjectName;
        public int grade;
        public PracticeReview review;

        public bool hasPassed() {
            return (int) review >= 4 && grade >= 55;
        }

        public bool hasCumLaude() {
            return (int) review == 5 && grade >= 80;
        }
    }
}
