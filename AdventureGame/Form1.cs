using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AdventureGame
{
    public partial class Form1 : Form
    {

        int scene = 1;
        int rngtest;
        Random rng = new Random();
        SoundPlayer ambient = new SoundPlayer(Properties.Resources.forestsound);  // Forest Ambience. Plays throughout. Shortened due to file sizes.
        SoundPlayer beastFind = new SoundPlayer(Properties.Resources.Beast1);
        SoundPlayer lose = new SoundPlayer(Properties.Resources.failure);

        public Form1()
        {
            InitializeComponent();
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (scene == 3)
            {
                rngtest = rng.Next(1, 101);
                if (rngtest <= 40) { scene = 15; }       // RNGS the probabiliy of a zergling - err, terrible beast - appearing.
                else { scene = 5; }
            }
           else if (scene == 4) { scene = 2; }
           else if (scene == 10) { scene = 12; }
            else if (scene == 11) { scene = 12; }
            else if (scene == 12) { scene = 5; }
            else if (scene == 15) { scene = 19; }
            else if (scene == 21) { scene = 5; }      // Yellow Button options.
            else if (scene == 19) { scene = 5; }
            else if (scene == 6) { scene = 1; }
            else if (scene == 7) { scene = 1; }
            else if (scene == 13) { scene = 1; }
            else if (scene == 14) { scene = 1; }
            else if (scene == 16) { scene = 1; }
            else if (scene == 17) { scene = 5; }
            else if (scene == 18) { scene = 1; }
            else if (scene == 20) { scene = 1; }
            Story();
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (scene == 1) { scene = 2; }
          else if (scene == 2) { scene = 4; }              // Blue button options.
           else if (scene == 5) { scene = 6; }
           else if (scene == 8) { scene = 9; }
           else if (scene == 9)
            {
                rngtest = rng.Next(1, 101);
                if (rngtest <= 30) { scene = 13; }    //RNGs the boat's stablity.
                else { scene = 10; }
            }
          else if (scene == 10) { scene = 11; }
         else if (scene == 15)
            {
                rngtest = rng.Next(1, 101);
                if (rngtest >= 50) { scene = 21; }  //RNGs how good you are at running with wet pants.
                else { scene = 20; }
            }
            Story();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if(scene == 1) { scene = 8; }
           else if(scene == 2) { scene = 3; }           // Red button options.
            else if(scene == 5) { scene = 7; }
            else if(scene == 8) { scene = 13; }
            else if(scene == 9) { scene = 5;  }
            else if(scene == 10) { scene = 14; }
            else if(scene == 15)
            {
                rngtest = rng.Next(1, 101);
                if(rngtest >= 85) { scene = 18; }           // RNGS your ability to fight.
                else if (rngtest <= 40) { scene = 16; }
                else { scene = 17; }
            }
            Story();
        }

        public void Story()
            //This is the story elements of the game, in 21 cases plus a failsafe. They may seem disjointed at first.
        {
            switch (scene)
            {
                case 1:
                    ambient.PlayLooping();
                    situationLabel.Image = AdventureGame.Properties.Resources.Forest;
                    outputLabel.Text = "This is the forest of illusion. Somehow you made your way in here, and you are completely lost. So lost there is not a path behind you. Do you go left, or right?";
                    yellowLabel.Text = "";
                    redLabel.Text = "Go right.";
                    blueLabel.Text = "Go left.";
                    Refresh();
                    break;
                case 2:
                    situationLabel.Image = AdventureGame.Properties.Resources.cliff;
                    outputLabel.Text = " Going left, you soon find yourself by a massive cliff, looking down at the forest below. You feel the urge to jump. Do you jump?";
                    yellowLabel.Text = "";
                    redLabel.Text = "Yes!";
                    blueLabel.Text = "Uh, no";
                    Refresh();
                    break;
                case 3:
                    outputLabel.Text = "You leap! And fall... and then land on your feet, perfectly fine. You see that the cliff is actually really small!";
                    yellowLabel.Text = "Oh.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "You sit there and don't do anything. You don't really have a choice; you have to jump.";
                    yellowLabel.Text = "Crap.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 5: 
                    situationLabel.Image = AdventureGame.Properties.Resources.forestedge;
                   outputLabel.Text = "You realize that the trees are thinner. In fact, you can see the edge of the forest from here! It's just along that path!";
                    yellowLabel.Text = "";
                    redLabel.Text = "Leg it!";
                    blueLabel.Text = "Go carefully; there may be a trap.";
                    break;
                case 6:
                    lose.Play();
                    outputLabel.Text = "You go slowly, and are proven right: there is a trap. You walk right into it and die of fall damage.";
                    yellowLabel.Text = "Restart...";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 7:
                    situationLabel.Image = Properties.Resources.win;
                    outputLabel.Text = "You jump for joy and leg it to the edge as fast as you can, leaping over a pit in the process. You burst out of the forest, and win the game!";
                    yellowLabel.Text = "Do it again!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    Refresh();
                    break;
                case 8:
                    situationLabel.Image = Properties.Resources.lake;
                    outputLabel.Text = "You find yourself by the shore of a massive, green lake. There is an island in the middle of it. Do you swim to the island?";
                    yellowLabel.Text = "";
                    redLabel.Text = "Swim!";
                    blueLabel.Text = "Nope.";
                    Refresh();
                    break;
                case 9:
                    outputLabel.Text = "You don't swim. Which is good, because you hate water. You look for another method, and spy a boat. You aren't good with boats, though. Where do you sail to?";
                    yellowLabel.Text = "";
                    redLabel.Text = "The other side.";
                    blueLabel.Text = "The island (risk of crashing)";
                    break;
                case 10:
                    outputLabel.Text = "You somehow get yourself to the island. It's a very, very nice island, with fruit trees and livestock and all that stuff. You feel the urge to stay.";
                    yellowLabel.Text = "Leave.";
                    redLabel.Text = "Stay.";
                    blueLabel.Text = "Explore.";
                    break;
                case 11:
                    outputLabel.Text = "Closer inspection of the island reveals absolutely nothing, and you are so bored from the search you choose to leave.";
                    yellowLabel.Text = "Onwards!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 12:
                    outputLabel.Text = "You go back to the boat and sail to the far side of the lake. For some reason the boat is more stable this way.";
                    yellowLabel.Text = "Right.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 13:
                    lose.Play();
                    outputLabel.Text = "You find yourself in the water. Except it isn't water, it's acid. You dissolve into literally nothing and die.";
                    yellowLabel.Text = "Restart.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 14:
                    situationLabel.Image = Properties.Resources.win;
                    outputLabel.Text = "You stay for a bit. And by a bit I mean forever. You live happily on the island for the rest of your life. You win, I guess.";
                    yellowLabel.Text = "Do it again!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 15:
                    ambient.Stop();
                    beastFind.Play();
                    situationLabel.Image = AdventureGame.Properties.Resources.beast;
                    outputLabel.Text = "Random Encounter! A terrible beast appears. It looks extremely dangerous and is approaching you slowly. Do you...";
                    yellowLabel.Text = "Attempt to reason?";
                    redLabel.Text = "Fight it off?";
                    blueLabel.Text = "Pee your pants and run?";
                    Refresh();
                    break;
                case 16:
                    situationLabel.Image = AdventureGame.Properties.Resources.Blood_death;
                    lose.Play();
                    outputLabel.Text = "You grab a stick and swing!... and miss. The beast, enraged, hops on you and begins attacking you with claw and fang. The result is so bloody I'm not allowed to describe it. Suffice to say, you die.";
                    yellowLabel.Text = "Restart...";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    Refresh();
                    break;
                case 17:
                    outputLabel.Text = "You grab a stick and smack the beast upside the head! At least you think it's the head. It stuns the beast. You take the oppurtunity to run.";
                    yellowLabel.Text = "Leg it!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "You grab a stick, and, in true badass-style, beat the beast into submission. You then mount it and ride it into the sunset (and out of the forest!). You win! ";
                    yellowLabel.Text = "Do it again!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "You recognize where the beast is from. You calmly explain to it that it's in the wrong game. Understanding, it nods and walks away.";
                    yellowLabel.Text = "Oooookay then.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 20:
                    lose.Play();
                    outputLabel.Text = "You pee yourself and run for your life. However, you trip over a gnat and fall. The beast catches you and tears you into little pieces. You die.";
                    yellowLabel.Text = "Restart...";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 21:
                    outputLabel.Text = "You pee yourself and run for your life. The beast follows, but falls in a river that you deftly leap. You sucessfully escape.";
                    yellowLabel.Text = "Thank all ye gods.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                default:
                    outputLabel.Text = "Riight, something messed up here. If this is here, then the game has bugged... Gonna have to restart.";
                    yellowLabel.Text = "Crap.";
                    redLabel.Text = "";             // Failsafe.
                    blueLabel.Text = "";
                    break;
            }
        }
    }
}