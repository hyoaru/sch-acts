#include <iostream>
#include<cstdlib>
#include<ctime>
#include <unistd.h>

using namespace std;

void printCards(int cards[2]) {
  cout << "\t" << "Cards: [" << cards[0] << ", " << cards[1] << "]\n";
}

int generateCard() {
  int min = 1;
  int max = 13;
  int randomCard = rand() % max + min;
  return randomCard;
}

void populateCards(int cards[2]) {
  cards[0] = generateCard();

  do {
    cards[1] = generateCard();
  } while (cards[1] <= cards[0]);
}

void printBalance(int userBalance, int computerBalance) {
  cout << "\n\tUser balance: " << userBalance << "\n\tComputer balance: " << computerBalance << "\n";
}

void printGameInformation() {
  cout << "Pl101 Midterms Requirement: In Between Game\n";
}

int main() {
  srand(time(0));
  int userBalance = 5000;
  int computerBalance = 5000;
  int playerRandomCards[2];
  
  int userBet;
  int cardDrawn;
  int passBalanceDeduction = 10;
  int defaultBalanceDeduction = 100; 
  string continuePromptUserInput = "y";
  
  do {
    system("clear");
    printGameInformation();
    populateCards(playerRandomCards);
    printBalance(userBalance, computerBalance);
    printCards(playerRandomCards);

    if (userBalance <= 0) {
      cout << "\tCard drawn: " << cardDrawn << "\n";
      cout << "\tYou lost!\n";
      break;
    } else if (computerBalance <= 0) {
      cout << "\tCard drawn: " << cardDrawn << "\n";
      cout << "\tYou won!\n";
      break;
    }
    
    cout << "\n[Y] Continue, [N] Pass: ";
    cin >> continuePromptUserInput;
    
    if (continuePromptUserInput == "y" || continuePromptUserInput == "Y") {
      system("clear");
      printGameInformation();
      printBalance(userBalance, computerBalance);
      printCards(playerRandomCards);

      if ((playerRandomCards[0] + 1) == playerRandomCards[1]) {
        cout << "\tYou lost " << defaultBalanceDeduction << "\n";
        userBalance -= defaultBalanceDeduction;
        computerBalance += defaultBalanceDeduction;
        
      } else {
        while (true) {
          cout << "\tHow much to bet?: ";
          cin >> userBet;
          if (userBet > userBalance || userBet > computerBalance) {
            system("clear");
            printGameInformation();
            printBalance(userBalance, computerBalance);
            printCards(playerRandomCards);
            cout << "\n\tInvalid bet value.\n";
            sleep(2);
          } else {
            break;
          }
        }
        
        cardDrawn = generateCard();
        cout << "\tCard drawn: " << cardDrawn << "\n";
  
        bool cardDrawnIsInBetween = cardDrawn > playerRandomCards[0] && cardDrawn < playerRandomCards[1];
        if (cardDrawnIsInBetween) {
          cout << "\tYou won " << userBet << "\n\n";
          userBalance += userBet;
          computerBalance -= userBet;
        } else {
          cout << "\tYou lost " << userBet << "\n\n";
          userBalance -= userBet;
          computerBalance += userBet;
          
        }
      }
      
      sleep(2);
    } else {
      userBalance -= passBalanceDeduction;
      computerBalance += passBalanceDeduction;
    }

  } while (userBalance > 0 || computerBalance > 0);

  
}