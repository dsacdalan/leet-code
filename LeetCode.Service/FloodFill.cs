namespace LeetCode.Service
{
    public partial class Solution
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
            // Only fill if it is a different color
            if (image[sr][sc] != newColor) Helper(image, sr, sc, newColor, image[sr][sc]);
            return image;
        }

        private void Helper(int[][] image, int sr, int sc, int newColor, int oldColor)
        {
            // Check valid image boundaries
            if (sr >= 0 && sr < image.Length && 
                sc >= 0 && sc < image[0].Length) // Assumes a non empty image
            {
                if (image[sr][sc] == oldColor)
                {
                    image[sr][sc] = newColor;
                    Helper(image, sr - 1, sc, newColor, oldColor); // UP
                    Helper(image, sr, sc + 1, newColor, oldColor); // RIGHT
                    Helper(image, sr + 1, sc, newColor, oldColor); // DOWN
                    Helper(image, sr, sc - 1, newColor, oldColor); // LEFT
                }
            }
        }
    }
}