using System;
using System.Collections.Generic;

public class ListVerse
{
    private List<string> verses = new List<string>
    {
        "1 Nephi 3:7 | And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
        "Moses 1:39 | For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.",
        "John 14:15 | If ye love me, keep my commandments.",
    };

    public string GetRandomVerse()
    {
        Random rand = new Random();
        return verses[rand.Next(verses.Count)];
    }
}
