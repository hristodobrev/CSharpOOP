# Heroes fight simulator
This is a simulator where you have few different weapons, shields and heroes. Each type has its own features. You can have various configurations made up with different items for different heroes. Below are described all the features of each item and hero.

# Heroes
Each hero has Name, Health, Weapon and Shield and the abilities to Attack and Defense. The attack considers the hero special abilities and the weapon, while the defense considers the hero special abilities and the shield.
### Basic Hero
This hero has no special abilities.
### Magic Hero
This hero has 20% chance on each attack to do one additional hit.

# Weapons
Each weapon has its own hit points, but the final damage is calculated randomly from 80% to 120% of the weapon hit points.
### Basic Weapon
This weapon has 10 points damage and no special effects.
### Magic Weapon
This weapon has 8 points damage but has 20% chance on each attack to cause double damage.

# Shields
Each shield has its own block rate points, but the final damage blocked is calculated randomly from 90% to 100% of the shield block rate points.
### Basic Shield
This shield has block rate of 3 points.
### Magic Shield
This shield has block rate of 2 points, but has 20% chance on each defense to double its block rate.

# Usage
In the beginning you are prompted to type in the weapon of the first hero, the weapon of the second hero, the shield of the first hero, the shield of the second hero, the hero type, name and health of the first hero and the hero type, name and health of the second hero respectively.

There are two options for weapons:
 - BasicWeapon
 - MagicWeapon

There are two options for shields:
 - BasicShield
 - MagicShield

There are two options for heroes:
 - BasicHero [HeroName] [HeroHealth]
 - MagicHero [HeroName] [HeroHealth]

# Example input
```
Please enter weapon1:
BasicWeapon
Please enter weapon2:
MagicWeapon
Please enter shield1:
MagicShield
Please enter shield2:
BasicShield
Please enter hero1:
MagicHero Pesho 100
Please enter hero2:
MagicHero Gosho 100
```

# Example output
```
Duel: (MagicHero) Pesho - 100HP vs (MagicHero) Gosho - 100HP
Gosho has taken 5 damage.
(MagicHero) Gosho - 95HP
Pesho has taken 14 damage.
Pesho has taken 4 damage.
(MagicHero) Pesho - 82HP
...
Gosho has taken 7 damage.
(MagicHero) Gosho - 5HP
Pesho has taken 6 damage.
(MagicHero) Pesho - -4HP
Gosho is winner!
```
