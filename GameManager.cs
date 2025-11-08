using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] cells;
    public GameObject xPrefab;
    public GameObject oPrefab;
    private string currentPlayer = "X";
    private string[] board = new string[9];

    public void CellClicked(int index)
    {
        if (board[index] == null)
        {
            GameObject mark = Instantiate(
                currentPlayer == "X" ? xPrefab : oPrefab,
                cells[index].transform.position + Vector3.up * 0.02f,
                Quaternion.identity
            );

            board[index] = currentPlayer;

            if (CheckWin())
            {
                Debug.Log(currentPlayer + " wins!");
            }
            else
            {
                currentPlayer = (currentPlayer == "X") ? "O" : "X";
            }
        }
    }

    bool CheckWin()
    {
        int[,] wins = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };
        for (int i = 0; i < wins.GetLength(0); i++)
        {
            if (board[wins[i, 0]] != null &&
                board[wins[i, 0]] == board[wins[i, 1]] &&
                board[wins[i, 1]] == board[wins[i, 2]])
                return true;
        }
        return false;
    }
}

