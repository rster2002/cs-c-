using System;
using System.Collections.Generic;

namespace Opdracht1 {
    class Program {
        InputMethods inputMethods = new InputMethods();

        static void Main(string[] args) {
            Program program = new Program();
            program.start();

            //Main(args); // For testing
        }

        void start() {
            List<Subject> subjects = new List<Subject>();

            subjects.Add(readSubject());
            subjects.Add(readSubject());
            subjects.Add(readSubject());

            showSubjectList(subjects);

            Console.ReadKey();
        }

        PracticeReview readPracticeReview() {
            foreach (PracticeReview value in Enum.GetValues(typeof(PracticeReview))) {
                Console.Write("{0}: {1} ", (int) value, value);
            }

            Console.WriteLine();

            int practiceInt = inputMethods.readInt(
                "Geef getal: ",
                "{0} is geen geldige mogelijkheid",
                1,
                5
            );

            return (PracticeReview) practiceInt;
        }

        void showPracticeReview(PracticeReview review) {
            Console.Write(review);
        }

        Subject readSubject() {
            Subject subject = new Subject();

            Console.WriteLine("Voer een vak in");

            subject.subjectName = inputMethods.readString("Geef de naam van het vak: ");
            subject.grade = inputMethods.readInt(
                $"Cijfer voor {subject.subjectName}: ",
                "{0} is geen geldig cijfer voor dit vak",
                1,
                100
            );

            subject.review = readPracticeReview();

            Console.WriteLine();

            return subject;
        }

        void showSubject(Subject subject) {
            Console.Write("Subject: {0}, Grade: {1}, Review: ", subject.subjectName, subject.grade);
            showPracticeReview(subject.review);
            Console.WriteLine();
        }

        void showSubjectList(List<Subject> subjects) {
            foreach (Subject subject in subjects) {
                showSubject(subject);
            }

            if (passedYear(subjects)) {
                if (passedYearCumLaude(subjects)) {
                    Console.WriteLine("Gefeliciteerd, je bent Cum Laude geslaagd");
                } else {
                    Console.WriteLine("Gefeliciteerd, je bent geslaagd");
                }
            } else {
                int subjectsFailed = countSubjectsFailed(subjects);
                Console.WriteLine("Helaas ben je gezakt. Je heb herkansingen voor {0} vak{1}", subjectsFailed, subjectsFailed > 1 ? "ken" : "");
            }
        }

        bool passedYearCumLaude(List<Subject> subjects) {
            foreach (Subject subject in subjects) {
                if (!subject.hasCumLaude()) {
                    return false;
                }
            }

            return true;
        }

        bool passedYear(List<Subject> subjects) {
            foreach (Subject subject in subjects) {
                if (!subject.hasPassed()) {
                    return false;
                }
            }

            return true;
        }

        int countSubjectsFailed(List<Subject> subjects) {
            int count = 0;

            foreach (Subject subject in subjects) {
                if (!subject.hasPassed()) {
                    count++;
                }
            }

            return count;
        }
    }
}
