namespace Opdracht_3 {
    public class RobotAdapter: IAttacker {
        private Robot robot;

        public RobotAdapter(Robot robot) {
            this.robot = robot;
        }

        public void assignDriver(string driver) => robot.moveByPerson(driver);
        public void driveForward(int positions) => robot.walkForward(positions);
        public void useWeapon() => robot.bashWithHands();
    }
}
