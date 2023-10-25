using UnityEngine;

public class CreateBoard : MonoBehaviour
{
    public GameObject[] piecePrefabs; // Array de GameObjects representando os prefabs das pe�as
    public int rows = 9; // N�mero de linhas
    public int columns = 11; // N�mero de colunas
    public float pieceSpacing = 1.0f; // Espa�amento entre as pe�as
    public GameObject[] startPieces; // Array das pe�as iniciais

    void Start()
    {
        CreateBoardPieces();
    }

    void CreateBoardPieces()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                int index = row * columns + col;
                if (index < startPieces.Length && startPieces[index] != null)
                {
                    Vector3 position = new Vector3(col * pieceSpacing, 0, row * pieceSpacing);
                    GameObject piecePrefab = startPieces[index];
                    GameObject piece = Instantiate(piecePrefab, position, Quaternion.identity);
                    piece.transform.parent = transform;
                }
            }
        }
    }
}
