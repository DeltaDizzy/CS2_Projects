using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelGame
{
    public partial class Form1 : Form
    {
        List<Panel> allRoomBounds, currentRoomBounds = new List<Panel>();
        CellData currentCell;
        Point oldPos;
        Regex gateId = new Regex("(gate[0-9])");
        List<CellData> rooms = new List<CellData>
        {
            new CellData(0, new List<int> {-1, 1, -1, -1}),
            new CellData(1, new List<int> {-1, 0, 2, -1}),
            new CellData(2, new List<int> { }),
            new CellData(3, new List<int> { }),
        };
        List<Bitmap> allsprites = new List<Bitmap>
        {
            Properties.Resources.up01, //0
            Properties.Resources.up02, //1
            Properties.Resources.up03, //2
            Properties.Resources.up04, //3
            Properties.Resources.down01, //4
            Properties.Resources.down02, //5
            Properties.Resources.down03, //6
            Properties.Resources.down04, //7
            Properties.Resources.right01, //8
            Properties.Resources.right02, //9
            Properties.Resources.right03, //10
            Properties.Resources.right04, //11
            Properties.Resources.left01, //12
            Properties.Resources.left02, //13
            Properties.Resources.left03, //14
            Properties.Resources.left04 //15
        };

        List<Bitmap> currentSprites = new List<Bitmap>();
        int speed;
        int currentSpriteIndex = 0;
        Vector2 moveDir = Vector2.Zero;
        public enum CharState
        {
            STATIC_NORTH,
            MOVING_NORTH,
            STATIC_SOUTH,
            MOVING_SOUTH,
            STATIC_EAST,
            MOVING_EAST,
            STATIC_WEST,
            MOVING_WEST
        }

        List<Image> currentStateSprites;

        CharState animPos = CharState.STATIC_NORTH;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGameState();
            var allBounds = from Panel p in Controls
                         select p;
            allRoomBounds = allBounds.Where(c => c.Tag.ToString().Contains("bound")).ToList();
            Console.WriteLine(allRoomBounds.Count);
            
        }

        private void UpdateGameState()
        {
            CheckCollisions();
            switch (animPos)
            {
                
                case CharState.STATIC_NORTH:
                    pbPlayer.Image = allsprites[0];
                    break;
                case CharState.STATIC_SOUTH:
                    pbPlayer.Image = allsprites[4];
                    break;
                case CharState.STATIC_EAST:
                    pbPlayer.Image = allsprites[12];
                    break;
                case CharState.STATIC_WEST:
                    pbPlayer.Image = allsprites[8];
                    break;
                case CharState.MOVING_NORTH:
                    currentSprites = allsprites.FindAll(b => allsprites.IndexOf(b) >= 0 && allsprites.IndexOf(b) <= 3);
                    break;
                case CharState.MOVING_SOUTH:
                    currentSprites = allsprites.FindAll(b => allsprites.IndexOf(b) >= 4 && allsprites.IndexOf(b) <= 7);
                    break;
                case CharState.MOVING_EAST:
                    currentSprites = allsprites.FindAll(b => allsprites.IndexOf(b) >= 11 && allsprites.IndexOf(b) <= 11);
                    break;
                case CharState.MOVING_WEST:
                    currentSprites = allsprites.FindAll(b => allsprites.IndexOf(b) >= 12 && allsprites.IndexOf(b) <= 15);
                    break;
                default:
                    break;
            }

            if (animPos % 2 != 0 )
            {
                currentSpriteIndex++;
                if (currentSpriteIndex == 3)
                {
                    currentSpriteIndex = 0;
                }
                pbPlayer.Image = currentSprites[currentSpriteIndex];
            }

        }

        private void tmrCharacter_Tick(object sender, EventArgs e)
        {
            pbPlayer.Top += (int)moveDir.Y;
            pbPlayer.Left += (int)moveDir.X;
            //update game state
            oldPos = pbPlayer.Location;
            UpdateGameState();
        }

        private void CheckCollisions()
        {
            for (int i = 0; i < currentRoomBounds.Count; i++)
            {
                if (pbPlayer.Bounds.IntersectsWith(currentRoomBounds[i].Bounds))
                {
                    if (gateId.IsMatch(currentRoomBounds[i].Name))
                    {
                        ChangeRoom(ExtractInt(currentRoomBounds[i].Name));
                    }
                    if (currentRoomBounds[i].Name.Contains("bound"))
                    {
                        pbPlayer.Location = oldPos;
                    }
                }
            }

            foreach (Panel collider in currentRoomBounds)
            {
                if (collider  )
                {

                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    moveDir.X = -speed;
                    animPos = CharState.MOVING_WEST;
                    break;
                case Keys.Up:
                    moveDir.Y = -speed;
                    animPos = CharState.MOVING_NORTH;
                    break;
                case Keys.Right:
                    moveDir.X = speed;
                    animPos = CharState.MOVING_EAST;
                    break;
                case Keys.Down:
                    moveDir.Y = speed;
                    animPos = CharState.MOVING_SOUTH;
                    break;
                default:
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            animPos -= 1;
        }

        private void ChangeRoom(int roomID)
        {
            // determine new room
            switch (roomID)
            {
                case 0:
                    if (currentCell.neighborIDList[0] != -1)
                    {
                        currentCell = rooms.Find(r => r.cellid == currentCell.neighborIDList[0]);
                    }
                    
                    break;
                case "south":
                    if (currentCell.neighborIDList[2] != -1)
                    {
                        currentCell = rooms.Find(r => r.cellid == currentCell.neighborIDList[2]);
                    }
                    break;
                case "east":
                    if (currentCell.neighborIDList[1] != -1)
                    {
                        currentCell = rooms.Find(r => r.cellid == currentCell.neighborIDList[1]);
                    }
                    break;
                case "west":
                    if (currentCell.neighborIDList[3] != -1)
                    {
                        currentCell = rooms.Find(r => r.cellid == currentCell.neighborIDList[3]);
                    }
                    break;
                default:
                    break;
            }
            //TODO: set bg image
            //change room bounds
            currentRoomBounds = allRoomBounds.Where(b => b.Tag.ToString().Contains($"room{currentCell.cellid}")).ToList();
        }

        

        private int ExtractInt(string input)
        {
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    result += input[i];
                }
            }
            if (result.Length > 0)
            {
                return int.Parse(result);
            }
            else return 0;
        }
    }
}
