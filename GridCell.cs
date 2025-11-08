using UnityEngine;

public class GridCell : MonoBehaviour
{
    public int cellIndex; // Each cell will have a number (0 to 8)
    public GameManager gameManager; // Reference to GameManager script

    // When player clicks or taps this cube
    private void OnMouseDown()
    {
        gameManager.CellClicked(cellIndex); // Tell the GameManager which cell was clicked
    }
}
