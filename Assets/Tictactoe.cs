using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tictactoe : MonoBehaviour {
 string[] cases = new string[9];
 int playerTurn;
 int pOneScore = 0;
 int pTwoScore = 0;
 int option = 0;
 bool wins = false;
 Color blueText = new Color(0, 252, 50);
 public Dropdown dropdown;
 public Text winsText;
 public Text playerText;
 public Text scoreText;
 public Button button0;
 public Button button1;
 public Button button2;
 public Button button3;
 public Button button4;
 public Button button5;
 public Button button6;
 public Button button7;
 public Button button8;
 public Sprite mask;
 public Sprite normal;
 public Sprite x;
 public Sprite o;

public void Btn(int num) {
 Button btn0 = button0.GetComponent<Button>();
 Button btn1 = button1.GetComponent<Button>();
 Button btn2 = button2.GetComponent<Button>();
 Button btn3 = button3.GetComponent<Button>();
 Button btn4 = button4.GetComponent<Button>();
 Button btn5 = button5.GetComponent<Button>();
 Button btn6 = button6.GetComponent<Button>();
 Button btn7 = button7.GetComponent<Button>();
 Button btn8 = button8.GetComponent<Button>();

 if (playerTurn %2 == 0 && option!=2) {
  cases[num] = "x";

 switch (num) {
  case 0:
   btn0.GetComponent<Image>().sprite = x;
   btn0.enabled = false;
  break;

  case 1:
   btn1.GetComponent<Image>().sprite = x;
   btn1.enabled = false;
  break;

  case 2:
   btn2.GetComponent<Image>().sprite = x;
   btn2.enabled = false;
  break;

  case 3:
   btn3.GetComponent<Image>().sprite = x;
   btn3.enabled = false;
  break;

  case 4:
   btn4.GetComponent<Image>().sprite = x;
   btn4.enabled = false;
  break;

  case 5:
   btn5.GetComponent<Image>().sprite = x;
   btn5.enabled = false;
  break;

  case 6:
   btn6.GetComponent<Image>().sprite = x;
   btn6.enabled = false;
  break;

  case 7:
   btn7.GetComponent<Image>().sprite = x;
   btn7.enabled = false;
  break;

  default:
   btn8.GetComponent<Image>().sprite = x;
   btn8.enabled = false;
  break;
 }
   playerTurn++;
   playerText.GetComponent<Text>().color = blueText;

 if (option==0) {
  playerText.text = "Player 2 turn";
 }

 else if (option == 1) {
  playerText.text = "Computer turn";
 }

  WinsCheck();

 if (option == 1 && playerTurn < 9) {
  AiTwo();
 }
 }

else if (playerTurn % 2 == 1 && option == 0) {
 cases[num] = "o";

switch (num) {
 case 0:
  btn0.GetComponent<Image>().sprite = o;
  btn0.enabled = false;
 break;

 case 1:
  btn1.GetComponent<Image>().sprite = o;
  btn1.enabled = false;
 break;

 case 2:
  btn2.GetComponent<Image>().sprite = o;
  btn2.enabled = false;
 break;

 case 3:
  btn3.GetComponent<Image>().sprite = o;
  btn3.enabled = false;
 break;

 case 4:
  btn4.GetComponent<Image>().sprite = o;
  btn4.enabled = false;
 break;

 case 5:
  btn5.GetComponent<Image>().sprite = o;
  btn5.enabled = false;
 break;

 case 6:
  btn6.GetComponent<Image>().sprite = o;
  btn6.enabled = false;
 break;

 case 7:
  btn7.GetComponent<Image>().sprite = o;
  btn7.enabled = false;
 break;

 default:
  btn8.GetComponent<Image>().sprite = o;
  btn8.enabled = false;
  break;
 }

  playerTurn++;
  playerText.GetComponent<Text>().color = Color.red;
  playerText.text = "Player 1 turn";
  WinsCheck();
  }
}

public void WinsCheck() {
 Button btn0 = button0.GetComponent<Button>();
 Button btn1 = button1.GetComponent<Button>();
 Button btn2 = button2.GetComponent<Button>();
 Button btn3 = button3.GetComponent<Button>();
 Button btn4 = button4.GetComponent<Button>();
 Button btn5 = button5.GetComponent<Button>();
 Button btn6 = button6.GetComponent<Button>();
 Button btn7 = button7.GetComponent<Button>();
 Button btn8 = button8.GetComponent<Button>();

 if ((cases[0] == "x" && cases[1] == "x" &&  cases[2] == "x") || (cases[0] == "x" && cases[3] == "x" && cases[6] == "x") || (cases[0] == "x" && cases[4] == "x" && cases[8] == "x") || (cases[1] == "x" && cases[4] == "x" && cases[7] == "x") || (cases[2] == "x" && cases[5] == "x" && cases[8] == "x") || (cases[2] == "x" && cases[4] == "x" && cases[6] == "x") || (cases[3] == "x" && cases[4] == "x" && cases[5] == "x") || (cases[6] == "x" && cases[7] == "x" && cases[8] == "x")) {
  pOneScore++;
  scoreText.text = pOneScore + "-" + pTwoScore;
  playerText.text = "";
  winsText.GetComponent<Text>().color = Color.red;
  wins = true;
  btn0.enabled = false;
  btn1.enabled = false;
  btn2.enabled = false;
  btn3.enabled = false;
  btn4.enabled = false;
  btn5.enabled = false;
  btn6.enabled = false;
  btn7.enabled = false;
  btn8.enabled = false;

 if (option != 2) {
  AppearText("Player 1 wins!");
 }

 else if (option == 2) {
  AppearText("Computer 1 wins!");
 }

 Invoke("NewGame", 2f);
 }

 if ((cases[0] == "o" && cases[1] == "o" && cases[2] == "o") || (cases[0] == "o" && cases[3] == "o" && cases[6] == "o") || (cases[0] == "o" && cases[4] == "o" && cases[8] == "o") || (cases[1] == "o" && cases[4] == "o" && cases[7] == "o") || (cases[2] == "o" && cases[5] == "o" && cases[8] == "o") || (cases[2] == "o" && cases[4] == "o" && cases[6] == "o") || (cases[3] == "o" && cases[4] == "o" && cases[5] == "o") || (cases[6] == "o" && cases[7] == "o" && cases[8] == "o")) {
  pTwoScore++;
  scoreText.text = pOneScore + "-" + pTwoScore;
  playerText.text = "";
  winsText.GetComponent<Text>().color = blueText;
  wins = true;
  btn0.enabled = false;
  btn1.enabled = false;
  btn2.enabled = false;
  btn3.enabled = false;
  btn4.enabled = false;
  btn5.enabled = false;
  btn6.enabled = false;
  btn7.enabled = false;
  btn8.enabled = false;

 if (option == 0) {
  AppearText("Player 2 wins!");
 }

 else if (option == 1) {
  AppearText("Computer wins!");
 }

 else if (option == 2) {
  AppearText("Computer 2 wins!");
 }

 Invoke("NewGame", 2f);
 }

 if (playerTurn >= 9 && wins == false) {
  scoreText.text = pOneScore + "-" + pTwoScore;
  playerText.text = "";
  winsText.GetComponent<Text>().color = Color.yellow;
  AppearText("Tie!");
  Invoke("NewGame", 2f);
 }
}

public void NewGame() {
 wins = false;
 winsText.enabled = false;
 playerTurn = 0;
 Array.Clear(cases, 0, cases.Length);
 Button btn0 = button0.GetComponent<Button>();
 Button btn1 = button1.GetComponent<Button>();
 Button btn2 = button2.GetComponent<Button>();
 Button btn3 = button3.GetComponent<Button>();
 Button btn4 = button4.GetComponent<Button>();
 Button btn5 = button5.GetComponent<Button>();
 Button btn6 = button6.GetComponent<Button>();
 Button btn7 = button7.GetComponent<Button>();
 Button btn8 = button8.GetComponent<Button>();
 playerText.GetComponent<Text>().color = Color.red;
 playerText.text = "Player 1 turn";
 btn0.enabled = true;
 btn1.enabled = true;
 btn2.enabled = true;
 btn3.enabled = true;
 btn4.enabled = true;
 btn5.enabled = true;
 btn6.enabled = true;
 btn7.enabled = true;
 btn8.enabled = true;
 btn0.GetComponent<Image>().sprite = normal;
 btn1.GetComponent<Image>().sprite = normal;
 btn2.GetComponent<Image>().sprite = normal;
 btn3.GetComponent<Image>().sprite = normal;
 btn4.GetComponent<Image>().sprite = normal;
 btn5.GetComponent<Image>().sprite = normal;
 btn6.GetComponent<Image>().sprite = normal;
 btn7.GetComponent<Image>().sprite = normal;
 btn8.GetComponent<Image>().sprite = normal;
}

public void Options() {
 int opt = dropdown.value;
 option = opt;
 RestartGame();
}

public void AiOne() {
 bool numberFound = false;
 int choice = UnityEngine.Random.Range(0, 8);

 while (numberFound == false) {
  Button btn0 = button0.GetComponent<Button>();
  Button btn1 = button1.GetComponent<Button>();
  Button btn2 = button2.GetComponent<Button>();
  Button btn3 = button3.GetComponent<Button>();
  Button btn4 = button4.GetComponent<Button>();
  Button btn5 = button5.GetComponent<Button>();
  Button btn6 = button6.GetComponent<Button>();
  Button btn7 = button7.GetComponent<Button>();
  Button btn8 = button8.GetComponent<Button>();

 if (cases[choice] != "x" && cases[choice] != "o") {
  cases[choice] = "x";

 switch (choice) {
  case 0:
   btn0.GetComponent<Image>().sprite = x;
   btn0.enabled = false;
   numberFound = true;
  break;

  case 1:
   btn1.GetComponent<Image>().sprite = x;
   btn1.enabled = false;
   numberFound = true;
  break;

  case 2:
   btn2.GetComponent<Image>().sprite = x;
   btn2.enabled = false;
   numberFound = true;
  break;

  case 3:
   btn3.GetComponent<Image>().sprite = x;
   btn3.enabled = false;
   numberFound = true;
  break;

  case 4:
   btn4.GetComponent<Image>().sprite = x;
   btn4.enabled = false;
   numberFound = true;
  break;

  case 5:
   btn5.GetComponent<Image>().sprite = x;
   btn5.enabled = false;
   numberFound = true;
  break;

  case 6:
   btn6.GetComponent<Image>().sprite = x;
   btn6.enabled = false;
   numberFound = true;
  break;

  case 7:
   btn7.GetComponent<Image>().sprite = x;
   btn7.enabled = false;
   numberFound = true;
  break;

  default:
   btn8.GetComponent<Image>().sprite = x;
   btn8.enabled = false;
   numberFound = true;
  break;
  }
  }

  else {
   choice = UnityEngine.Random.Range(0, 8);
  }
  }

 playerTurn++;
 playerText.GetComponent<Text>().color = Color.red;
 WinsCheck();
 }

 public void AiTwo() {
  bool numberFound = false;
  int choice = UnityEngine.Random.Range(0, 8);
        
  while (numberFound == false) {
   Button btn0 = button0.GetComponent<Button>();
   Button btn1 = button1.GetComponent<Button>();
   Button btn2 = button2.GetComponent<Button>();
   Button btn3 = button3.GetComponent<Button>();
   Button btn4 = button4.GetComponent<Button>();
   Button btn5 = button5.GetComponent<Button>();
   Button btn6 = button6.GetComponent<Button>();
   Button btn7 = button7.GetComponent<Button>();
   Button btn8 = button8.GetComponent<Button>();

  if (cases[choice]!= "x" && cases[choice] != "o") {
   cases[choice] = "o";

  switch (choice) {
   case 0:
    btn0.GetComponent<Image>().sprite = o;
    btn0.enabled = false;
    numberFound = true;
   break;

   case 1:
    btn1.GetComponent<Image>().sprite = o;
    btn1.enabled = false;
    numberFound = true;
   break;

   case 2:
    btn2.GetComponent<Image>().sprite = o;
    btn2.enabled = false;
    numberFound = true;
   break;

   case 3:
    btn3.GetComponent<Image>().sprite = o;
    btn3.enabled = false;
    numberFound = true;
   break;

   case 4:
    btn4.GetComponent<Image>().sprite = o;
    btn4.enabled = false;
    numberFound = true;
   break;

   case 5:
    btn5.GetComponent<Image>().sprite = o;
    btn5.enabled = false;
    numberFound = true;
   break;

   case 6:
    btn6.GetComponent<Image>().sprite = o;
    btn6.enabled = false;
    numberFound = true;
   break;

   case 7:
    btn7.GetComponent<Image>().sprite = o;
    btn7.enabled = false;
    numberFound = true;
   break;

   default:
    btn8.GetComponent<Image>().sprite = o;
    btn8.enabled = false;
    numberFound = true;
   break;
  }
  }

  else {
   choice = UnityEngine.Random.Range(0, 8);
  }
  }

   playerTurn++;
   playerText.GetComponent<Text>().color = Color.red;
   playerText.text = "Player 1 turn";
   WinsCheck();
   }

  public void RestartGame() {
   pOneScore = 0;
   pTwoScore = 0;
   scoreText.text = pOneScore + "-" + pTwoScore;
   NewGame();
   }

  public string AppearText(string text) {
   Button btn0 = button0.GetComponent<Button>();
   Button btn1 = button1.GetComponent<Button>();
   Button btn2 = button2.GetComponent<Button>();
   Button btn3 = button3.GetComponent<Button>();
   Button btn4 = button4.GetComponent<Button>();
   Button btn5 = button5.GetComponent<Button>();
   Button btn6 = button6.GetComponent<Button>();
   Button btn7 = button7.GetComponent<Button>();
   Button btn8 = button8.GetComponent<Button>();
   winsText.text = text;
   winsText.enabled = true;
   btn0.GetComponent<Image>().sprite = mask;
   btn1.GetComponent<Image>().sprite = mask;
   btn2.GetComponent<Image>().sprite = mask;
   btn3.GetComponent<Image>().sprite = mask;
   btn4.GetComponent<Image>().sprite = mask;
   btn5.GetComponent<Image>().sprite = mask;
   btn6.GetComponent<Image>().sprite = mask;
   btn7.GetComponent<Image>().sprite = mask;
   btn8.GetComponent<Image>().sprite = mask;
   return text;
  }

  void Start() {
   winsText.enabled = false;
  }
}
