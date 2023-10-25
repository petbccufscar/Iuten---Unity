using UnityEngine;

public class CreateBoard : MonoBehaviour
{
    public GameObject[] piecePrefabs; // Array de GameObjects representando os prefabs das peças
    public int rows = 9; // Número de linhas
    public int columns = 11; // Número de colunas
    public float pieceSpacing = 1.0f; // Espaçamento entre as peças
    public GameObject[] startPieces; // Array das peças iniciais

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
