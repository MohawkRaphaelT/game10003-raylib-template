﻿/// <summary>
///     
/// </summary>
public readonly record struct Sound
{
    public Raylib_cs.Sound RaylibSound { get; init; }

    public static implicit operator Sound(Raylib_cs.Sound raylibSound)
    {
        var font = new Sound()
        {
            RaylibSound = raylibSound,
        };
        return font;
    }
    public static implicit operator Raylib_cs.Sound(Sound sound)
    {
        var raylibSound = sound.RaylibSound;
        return raylibSound;
    }
}