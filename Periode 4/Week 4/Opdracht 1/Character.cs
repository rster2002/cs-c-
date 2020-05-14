namespace Opdracht_1 {
    abstract class Character {
        public IWeaponBehaviour weapon;

        public void fight() => weapon.useWeapon();
    }
}
