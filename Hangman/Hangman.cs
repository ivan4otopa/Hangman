namespace Hangman
{
    class Hangman
    {
        private const int StartNumberOfLives = 6;

        public Hangman()
        {
            this.Lives = StartNumberOfLives;
        }

        public int Lives { get; set; }

        public string Print()
        {
            switch (this.Lives)
            {
                case 0:
                    return "_______________\n" +
                            "|            |\n" +
                            "|           ( )\n" +
                            "|            |\n" +
                            "|           /|\\\n" +
                            "|          / | \\\n" +
                            "|            |\n" +
                            "|           / \\\n" +
                            "|          /   \\";
                case 1:
                    return "_______________\n" +
                            "|            |\n" +
                            "|           ( )\n" +
                            "|            |\n" +
                            "|           /|\\\n" +
                            "|          / | \\\n" +
                            "|            |\n" +
                            "|\n" +
                            "|";
                case 2:
                    return "_______________\n" +
                            "|            |\n" +
                            "|           ( )\n" +
                            "|            |\n" +
                            "|           /|\\\n" +
                            "|          / | \\\n" +
                            "|\n" +
                            "|\n" +
                            "|";
                case 3:
                    return "_______________\n" +
                            "|            |\n" +
                            "|           ( )\n" +
                            "|            |\n" +
                            "|\n" +
                            "|\n" +
                            "|\n" +
                            "|\n" +
                            "|";
                case 4:
                    return "_______________\n" +
                            "|            |\n" +
                            "|           ( )\n" +
                            "|\n" +
                            "|\n" +
                            "|\n" +
                            "|\n" +
                            "|\n" +
                            "|\n";
                case 5:
                    return "_______________\n" +
                            "|            |\n" +
                            "|\n" +
                            "|\n" +
                            "|\n" +
                            "|\n" +
                            "|\n" +
                            "|\n" +
                            "|";
                case 6:
                    return "_______________\n" +
                            "|\n" +
                            "|\n" +
                            "|\n" +
                            "|\n" +
                            "|\n" +
                            "|\n" +
                            "|\n" +
                            "|";
            }

            return "";
        }
    }
}
