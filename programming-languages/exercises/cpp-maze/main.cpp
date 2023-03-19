#include <iostream>
#include <stdio.h>
#include <stdlib.h>

using namespace std;

int keypress() {
  system ("/bin/stty raw");
  int c;
  system("/bin/stty -echo");
  c = getc(stdin);
  system("/bin/stty echo");
  system ("/bin/stty cooked");
  return c;
}

void gotoXY(int x, int y) { 
  cout << "\x1b[" << y << ";" << x << "H"; 
}

int getVerticalOffset(){
  // Vertical offset from origin
  int offsetVertical = 10;
  return offsetVertical;
}

int getHorizontalOffset(){
  // Horizontal offset from origin
  int offsetHorizontal = 15;
  return offsetHorizontal;
}

void printHorizontalLine(int startingX, int startingY, int endingX) {
  // Offset from origin
  int offsetVertical = getVerticalOffset();
  int offsetHorizontal = getHorizontalOffset();
  
  startingX += offsetHorizontal;
  startingY += offsetVertical;
  endingX += offsetHorizontal;
  
  for (int i = startingX; i < endingX; i++) {
    gotoXY(i, startingY);
    cout << "-";
  }
}

void printVerticalLine(int startingX, int startingY, int endingY) {
  // Offset from origin
  int offsetVertical = getVerticalOffset();
  int offsetHorizontal = getHorizontalOffset();
  
  startingX += offsetHorizontal;
  startingY += offsetVertical;
  endingY += offsetVertical;
  
  for (int i = startingY; i < endingY + 1; i++) {
    gotoXY(startingX, i);
    cout << "|";
  }
}

void printMaze() {
  // Outer box -
  printHorizontalLine(0, 0, 44);
  printHorizontalLine(48, 0, 50);
  printHorizontalLine(0, 16, 3);
  printHorizontalLine(7, 16, 50);
  printVerticalLine(0, 0,16);
  printVerticalLine(50, 0,16);

  // Inner box -
  // Three level horizontal
  printHorizontalLine(4, 4, 17);
  printHorizontalLine(21, 4, 25);
  printHorizontalLine(29, 4, 36);
  printHorizontalLine(40, 4, 50);

  printHorizontalLine(1, 8, 10);
  printHorizontalLine(14, 8, 35);
  printHorizontalLine(39, 8, 50);

  printHorizontalLine(4, 12, 10);
  printHorizontalLine(14, 12, 40);
  printHorizontalLine(44, 12, 50);

  // Details --
  // Layer 1
  printVerticalLine(47, 0, 2);
  printVerticalLine(44, 0, 0);
  printHorizontalLine(29, 2, 47);
  printVerticalLine(28, 2, 6);
  printVerticalLine(25, 2, 4);
  printHorizontalLine(4, 2, 25);
  printVerticalLine(3, 2, 4);

  // Layer 2
  printVerticalLine(17, 4, 6);
  printVerticalLine(20, 4, 8);
  printVerticalLine(36, 4, 6);
  printVerticalLine(39, 4, 6);
  printHorizontalLine(40, 6, 43);
  printHorizontalLine(47, 6, 50);
  printVerticalLine(43, 6, 6);
  printVerticalLine(46, 6, 6);
  printHorizontalLine(21, 6, 28);
  printHorizontalLine(29, 6, 33);
  printVerticalLine(33, 6, 6);
  printVerticalLine(14, 6, 6);
  printHorizontalLine(4, 6, 14);
  printVerticalLine(3, 6, 8);

  // Layer 3
  printVerticalLine(10, 8, 10);
  printVerticalLine(13, 8, 10);
  printVerticalLine(35, 8, 12);
  printVerticalLine(38, 8, 10);
  printHorizontalLine(1, 10, 4);
  printHorizontalLine(7, 10, 10);
  printVerticalLine(4, 10, 10);
  printVerticalLine(7, 10, 12);
  printHorizontalLine(14, 10, 25);
  printHorizontalLine(29, 10, 35);
  printVerticalLine(25, 10, 10);
  printVerticalLine(28, 10, 10);
  printVerticalLine(41, 10, 10);
  printHorizontalLine(42, 10, 50);
  
  // Layer 4
  printVerticalLine(3, 12, 14);
  printVerticalLine(10, 12, 12);
  printVerticalLine(13, 12, 12);
  printVerticalLine(40, 12, 14);
  printVerticalLine(43, 12, 12);
  printHorizontalLine(4, 14, 37);
  printHorizontalLine(41, 14, 47);
  printVerticalLine(37, 14, 14);
  printVerticalLine(47, 14, 14);
  printVerticalLine(3, 16, 16);
  printVerticalLine(6, 16, 16);
  
}

void showStats(int userXPosition, int userYPosition, bool isWayCoordinate) {
  // Stats
  gotoXY(0, 0);
  cout << "X coordinate: " << userXPosition;
  gotoXY(0, 2);
  cout << "Y coordinate: " << userYPosition;
  gotoXY(0, 3);
  cout << "Is way coordinate: " << isWayCoordinate;
  
}

void moveUser(int userXPosition, int userYPosition) {
  gotoXY(userXPosition, userYPosition);
  cout << "X";
}

void setArrayContent(int xStart, int xEnd, int y_const, int arr[xEnd - xStart][2]) {
  int offsetVertical = getVerticalOffset();
  int offsetHorizontal = getHorizontalOffset();

  xStart += offsetHorizontal;
  xEnd += offsetHorizontal;
  y_const += offsetVertical;
  
  int x = xStart;
  for (int i = 0; i < xEnd - xStart; ++i) {
    arr[i][0] = x;
    arr[i][1] = y_const;
    ++x;
  }
}

bool isWayCoordinate(int x, int y, int xStart, int xEnd, int arr[xEnd - xStart][2]) {
  for (int i = 0; i < (xEnd - xStart); i++) {
    int xCoord = arr[i][0];
    int yCoord = arr[i][1];
    if ((x == xCoord) && (y == yCoord)) {
      return true;
    }
  }
  return false;
}

bool checkIfWayCoordinate(int x, int y) {
  int coords1x1[47-1][2];
  setArrayContent(1, 47, 1, coords1x1);
  bool coords1x1IsWayCoordinate = isWayCoordinate(x, y, 1, 47, coords1x1);

  int coords1x2[50-48][2];
  setArrayContent(48, 50, 1, coords1x2);
  bool coords1x2IsWayCoordinate = isWayCoordinate(x, y, 48, 50, coords1x2);

  int coords2x1[3-1][2];
  setArrayContent(1, 3, 2, coords2x1);
  bool coords2x1IsWayCoordinate = isWayCoordinate(x, y, 1, 3, coords2x1);

  int coords2x2[28-26][2];
  setArrayContent(26, 28, 2, coords2x2);
  bool coords2x2IsWayCoordinate = isWayCoordinate(x, y, 26, 28, coords2x2);

  int coords2x3[50-48][2];
  setArrayContent(48, 50, 2, coords2x3);
  bool coords2x3IsWayCoordinate = isWayCoordinate(x, y, 48, 50, coords2x3);

  int coords3x1[3-1][2];
  setArrayContent(1, 3, 3, coords3x1);
  bool coords3x1IsWayCoordinate = isWayCoordinate(x, y, 1, 3, coords3x1);

  int coords3x2[25-4][2];
  setArrayContent(4, 25, 3, coords3x2);
  bool coords3x2IsWayCoordinate = isWayCoordinate(x, y, 4, 25, coords3x2);

  int coords3x3[28-26][2];
  setArrayContent(26, 28, 3, coords3x3);
  bool coords3x3IsWayCoordinate = isWayCoordinate(x, y, 26, 28, coords3x3);

  int coords3x4[50-29][2];
  setArrayContent(29, 50, 3, coords3x4);
  bool coords3x4IsWayCoordinate = isWayCoordinate(x, y, 29, 50, coords3x4);

  int coords4x1[3-1][2];
  setArrayContent(1, 3, 4, coords4x1);
  bool coords4x1IsWayCoordinate = isWayCoordinate(x, y, 1, 3, coords4x1);

  int coords4x2[20-18][2];
  setArrayContent(18, 20, 4, coords4x2);
  bool coords4x2IsWayCoordinate = isWayCoordinate(x, y, 18, 20, coords4x2);

  int coords4x3[28-26][2];
  setArrayContent(26, 28, 4, coords4x3);
  bool coords4x3IsWayCoordinate = isWayCoordinate(x, y, 26, 28, coords4x3);

  int coords4x4[39-37][2];
  setArrayContent(37, 39, 4, coords4x4);
  bool coords4x4IsWayCoordinate = isWayCoordinate(x, y, 37, 39, coords4x4);

  int coords5x1[17-1][2];
  setArrayContent(1, 17, 5, coords5x1);
  bool coords5x1IsWayCoordinate = isWayCoordinate(x, y, 1, 17, coords5x1);

  int coords5x2[20-18][2];
  setArrayContent(18, 20, 5, coords5x2);
  bool coords5x2IsWayCoordinate = isWayCoordinate(x, y, 18, 20, coords5x2);

  int coords5x3[28-21][2];
  setArrayContent(21, 28, 5, coords5x3);
  bool coords5x3IsWayCoordinate = isWayCoordinate(x, y, 21, 28, coords5x3);

  int coords5x4[36-29][2];
  setArrayContent(29, 36, 5, coords5x4);
  bool coords5x4IsWayCoordinate = isWayCoordinate(x, y, 29, 36, coords5x4);

  int coords5x5[39-37][2];
  setArrayContent(37, 39, 5, coords5x5);
  bool coords5x5IsWayCoordinate = isWayCoordinate(x, y, 37, 39, coords5x5);

  int coords5x6[50-40][2];
  setArrayContent(40, 50, 5, coords5x6);
  bool coords5x6IsWayCoordinate = isWayCoordinate(x, y, 40, 50, coords5x6);

  int coords6x1[3-1][2];
  setArrayContent(1, 3, 6, coords6x1);
  bool coords6x1IsWayCoordinate = isWayCoordinate(x, y, 1, 3, coords6x1);

  int coords6x2[17-15][2];
  setArrayContent(15, 17, 6, coords6x2);
  bool coords6x2IsWayCoordinate = isWayCoordinate(x, y, 15, 17, coords6x2);

  int coords6x3[20-18][2];
  setArrayContent(18, 20, 6, coords6x3);
  bool coords6x3IsWayCoordinate = isWayCoordinate(x, y, 18, 20, coords6x3);

  int coords6x4[36-34][2];
  setArrayContent(34, 36, 6, coords6x4);
  bool coords6x4IsWayCoordinate = isWayCoordinate(x, y, 34, 36, coords6x4);

  int coords6x5[39-37][2];
  setArrayContent(37, 39, 6, coords6x5);
  bool coords6x5IsWayCoordinate = isWayCoordinate(x, y, 37, 39, coords6x5);

  int coords6x6[46-44][2];
  setArrayContent(44, 46, 6, coords6x6);
  bool coords6x6IsWayCoordinate = isWayCoordinate(x, y, 44, 46, coords6x6);

  int coords7x1[3-1][2];
  setArrayContent(1, 3, 7, coords7x1);
  bool coords7x1IsWayCoordinate = isWayCoordinate(x, y, 1, 3, coords7x1);

  int coords7x2[20-4][2];
  setArrayContent(4, 20, 7, coords7x2);
  bool coords7x2IsWayCoordinate = isWayCoordinate(x, y, 4, 20, coords7x2);

  int coords7x3[50-21][2];
  setArrayContent(21, 50, 7, coords7x3);
  bool coords7x3IsWayCoordinate = isWayCoordinate(x, y, 21, 50, coords7x3);

  int coords8x1[13-11][2];
  setArrayContent(11, 13, 8, coords8x1);
  bool coords8x1IsWayCoordinate = isWayCoordinate(x, y, 11, 13, coords8x1);

  int coords8x2[38-36][2];
  setArrayContent(36, 38, 8, coords8x2);
  bool coords8x2IsWayCoordinate = isWayCoordinate(x, y, 36, 38, coords8x2);

  int coords9x1[10-1][2];
  setArrayContent(1, 10, 9, coords9x1);
  bool coords9x1IsWayCoordinate = isWayCoordinate(x, y, 1, 10, coords9x1);

  int coords9x2[13-11][2];
  setArrayContent(11, 13, 9, coords9x2);
  bool coords9x2IsWayCoordinate = isWayCoordinate(x, y, 11, 13, coords9x2);

  int coords9x3[35-14][2];
  setArrayContent(14, 35, 9, coords9x3);
  bool coords9x3IsWayCoordinate = isWayCoordinate(x, y, 14, 35, coords9x3);

  int coords9x4[38-36][2];
  setArrayContent(36, 38, 9, coords9x4);
  bool coords9x4IsWayCoordinate = isWayCoordinate(x, y, 36, 38, coords9x4);

  int coords9x5[50-39][2];
  setArrayContent(39, 50, 9, coords9x5);
  bool coords9x5IsWayCoordinate = isWayCoordinate(x, y, 39, 50, coords9x5);

  int coords10x1[7-5][2];
  setArrayContent(5, 7, 10, coords10x1);
  bool coords10x1IsWayCoordinate = isWayCoordinate(x, y, 5, 7, coords10x1);

  int coords10x2[13-11][2];
  setArrayContent(11, 13, 10, coords10x2);
  bool coords10x2IsWayCoordinate = isWayCoordinate(x, y, 11, 13, coords10x2);

  int coords10x3[28-26][2];
  setArrayContent(26, 28, 10, coords10x3);
  bool coords10x3IsWayCoordinate = isWayCoordinate(x, y, 26, 28, coords10x3);

  int coords10x4[38-36][2];
  setArrayContent(36, 38, 10, coords10x4);
  bool coords10x4IsWayCoordinate = isWayCoordinate(x, y, 36, 38, coords10x4);

  int coords10x5[41-39][2];
  setArrayContent(39, 41, 10, coords10x5);
  bool coords10x5IsWayCoordinate = isWayCoordinate(x, y, 39, 41, coords10x5);

  int coords11x1[7-1][2];
  setArrayContent(1, 7, 11, coords11x1);
  bool coords11x1IsWayCoordinate = isWayCoordinate(x, y, 1, 7, coords11x1);

  int coords11x2[35-8][2];
  setArrayContent(8, 35, 11, coords11x2);
  bool coords11x2IsWayCoordinate = isWayCoordinate(x, y, 8, 35, coords11x2);

  int coords11x3[50-36][2];
  setArrayContent(36, 50, 11, coords11x3);
  bool coords11x3IsWayCoordinate = isWayCoordinate(x, y, 36, 50, coords11x3);

  int coords12x1[3-1][2];
  setArrayContent(1, 3, 12, coords12x1);
  bool coords12x1IsWayCoordinate = isWayCoordinate(x, y, 1, 3, coords12x1);

  int coords12x2[13-11][2];
  setArrayContent(11, 13, 12, coords12x2);
  bool coords12x2IsWayCoordinate = isWayCoordinate(x, y, 11, 13, coords12x2);

  int coords12x3[43-41][2];
  setArrayContent(41, 43, 12, coords12x3);
  bool coords12x3IsWayCoordinate = isWayCoordinate(x, y, 41, 43, coords12x3);

  int coords13x1[3-1][2];
  setArrayContent(1, 3, 13, coords13x1);
  bool coords13x1IsWayCoordinate = isWayCoordinate(x, y, 1, 3, coords13x1);

  int coords13x2[40-4][2];
  setArrayContent(4, 40, 13, coords13x2);
  bool coords13x2IsWayCoordinate = isWayCoordinate(x, y, 4, 40, coords13x2);

  int coords13x3[50-41][2];
  setArrayContent(41, 50, 13, coords13x3);
  bool coords13x3IsWayCoordinate = isWayCoordinate(x, y, 41, 50, coords13x3);

  int coords14x1[3-1][2];
  setArrayContent(1, 3, 14, coords14x1);
  bool coords14x1IsWayCoordinate = isWayCoordinate(x, y, 1, 3, coords14x1);

  int coords14x2[40-38][2];
  setArrayContent(38, 40, 14, coords14x2);
  bool coords14x2IsWayCoordinate = isWayCoordinate(x, y, 38, 40, coords14x2);

  int coords14x3[50-48][2];
  setArrayContent(48, 50, 14, coords14x3);
  bool coords14x3IsWayCoordinate = isWayCoordinate(x, y, 48, 50, coords14x3);

  int coords15x1[50-1][2];
  setArrayContent(1, 50, 15, coords15x1);
  bool coords15x1IsWayCoordinate = isWayCoordinate(x, y, 1, 50, coords15x1);

  int coords16x1[6-4][2];
  setArrayContent(4, 6, 16, coords16x1);
  bool coords16x1IsWayCoordinate = isWayCoordinate(x, y, 4, 6, coords16x1);

  int coords17x1[50-0][2];
  setArrayContent(0, 50, 17, coords17x1);
  bool coords17x1IsWayCoordinate = isWayCoordinate(x, y, 0, 50, coords17x1);
  
  int sum = 0;
  bool checkedWayCoordinates[] = {
    coords1x1IsWayCoordinate, coords1x2IsWayCoordinate,
    coords2x1IsWayCoordinate, coords2x2IsWayCoordinate, coords2x3IsWayCoordinate,
    coords3x1IsWayCoordinate, coords3x2IsWayCoordinate, coords3x3IsWayCoordinate, coords3x4IsWayCoordinate, 
    coords4x1IsWayCoordinate, coords4x2IsWayCoordinate, coords4x3IsWayCoordinate, coords4x4IsWayCoordinate, 
    coords5x1IsWayCoordinate, coords5x2IsWayCoordinate, coords5x3IsWayCoordinate, coords5x4IsWayCoordinate, coords5x5IsWayCoordinate, coords5x6IsWayCoordinate, 
    coords6x1IsWayCoordinate, coords6x2IsWayCoordinate, coords6x3IsWayCoordinate, coords6x4IsWayCoordinate, coords6x5IsWayCoordinate, coords6x6IsWayCoordinate, 
    coords7x1IsWayCoordinate, coords7x2IsWayCoordinate, coords7x3IsWayCoordinate,
    coords8x1IsWayCoordinate, coords8x2IsWayCoordinate, 
    coords9x1IsWayCoordinate, coords9x2IsWayCoordinate, coords9x3IsWayCoordinate, coords9x4IsWayCoordinate, coords9x5IsWayCoordinate, 
    coords10x1IsWayCoordinate, coords10x2IsWayCoordinate, coords10x3IsWayCoordinate, coords10x4IsWayCoordinate, coords10x5IsWayCoordinate, 
    coords11x1IsWayCoordinate, coords11x2IsWayCoordinate, coords11x3IsWayCoordinate,
    coords12x1IsWayCoordinate, coords12x2IsWayCoordinate, coords12x3IsWayCoordinate,
    coords13x1IsWayCoordinate, coords13x2IsWayCoordinate, coords13x3IsWayCoordinate,
    coords14x1IsWayCoordinate, coords14x2IsWayCoordinate, coords14x3IsWayCoordinate,
    coords15x1IsWayCoordinate, 
    coords16x1IsWayCoordinate, 
    coords17x1IsWayCoordinate, 
  };
  
  for (bool checkedWayCoordinate: checkedWayCoordinates) {
    if (checkedWayCoordinate) {
      sum++;
    }
  }
  
  if (sum > 0) {
    return true;
  } else {
    return false;
  }
}



int main() {
  int offsetVertical = getVerticalOffset();
  int offsetHorizontal = getHorizontalOffset();

  int initialUserXPosition = 4 + offsetHorizontal;
  int initialUserYPosition = 17 + offsetVertical;
  int userXPosition = initialUserXPosition;
  int userYPosition = initialUserYPosition;

  int XPositionUpperLimit = (50 + offsetHorizontal);
  int XPositionLowerLimit = (0 + offsetHorizontal);
  int YPositionUpperLimit = (17 + offsetVertical);
  int YPositionLowerLimit = (0 + offsetVertical);

  bool gameRun = true;
  while (gameRun) {
    system("clear");
    printMaze();
    gotoXY(userXPosition, userYPosition);
    
    int keypressed = keypress();
    bool keypressedW = (keypressed == 119) || (keypressed == 87);
    bool keypressedA = (keypressed == 97) || (keypressed == 65);
    bool keypressedS = (keypressed == 83) || (keypressed == 115);
    bool keypressedD = (keypressed == 68) || (keypressed == 100);

    if (keypressedW && userYPosition > YPositionLowerLimit) {
      userYPosition--;
    } else if (keypressedS && userYPosition < YPositionUpperLimit) {
      userYPosition++;
    } else if (keypressedA && userXPosition > XPositionLowerLimit) {
      userXPosition--;
    } else if (keypressedD && userXPosition < XPositionUpperLimit) {
      userXPosition++;
    }

    moveUser(userXPosition, userYPosition);
    bool isWayCoordinate = checkIfWayCoordinate(userXPosition, userYPosition);
    showStats(userXPosition - offsetHorizontal, userYPosition - offsetVertical, isWayCoordinate);
    bool isCollidingWithWalls = !isWayCoordinate;
    
    if (isCollidingWithWalls) {
      userXPosition = initialUserXPosition;
      userYPosition = initialUserYPosition;
    }
  }
}
