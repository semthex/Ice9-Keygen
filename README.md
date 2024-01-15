# Ice9 Keygen
This is a keygen for the Ice9 crackme by TripleTordo. You can find a link to the original crackme [here](https://crackmes.one/crackme/5ab77f6633c5d40ad448cbe2).
This keygen is stylized using the retro keygen aesthetic of the early 2000s. For instructions on how to use this tool, scroll down to the next section below.
Later in this README is a breakdown of the serial generation algorithm that the Ice9 crackme uses.

![Ice9-Keygen-UI](https://github.com/JulianOzelRose/Ice9-Keygen/assets/95890436/14e13376-baa3-49b9-a652-ba084ca36dfc)

## Installation and use
To use this keygen, simply navigate to the [Release](https://github.com/JulianOzelRose/Ice9-Keygen/tree/master/Ice9-Keygen/bin/x64/Release)
folder, then download ```Ice9-Keygen.exe```. You can store it anywhere on your computer, and no installation is necessary -- just download
and run. Once open, simply enter the name and click "Generate" to get a valid serial. You can also click "Copy" to add the serial
number to your clipboard.

## Track list
This keygen plays several chiptunes (i.e. "keygen music") as per the retro keygen aesthetic. It cylces through the playlist automatically.
You can mute or unmute it by using the checkbox in the bottom left corner. This keygen uses the SharpMik library to play XM audio files.
You can find a link to the archive of the XM files used for this keygen [here](https://archive.org/details/essential-keygen-music).
Below is a list of the tracks used:

1. "unreeeal superhero 3" by _rez+kenet_
2. "Valium candies" by _Jakim_
3. "orion spaceforce23" by _dualtrax_
4. "sleepy sunflower" by _HyoChan_

## Anti-debugging
If you wish the reverse this crackme and step through the code, you will have to disable the ```IsDebuggerPresent()``` function that is called
on offset 0x469 of the primary module. You can do this by changing the very next instruction to ```cmp eax, 0```. Since the function that checks
for a debugger returns a boolean value, this effectively disables the debugger check.

## Serial generation algorithm
Before mutating the name into a serial, the program first checks to ensure the length of the name is between 4 and 10 characters long.
Once a valid length is verified, the user-entered name is pushed onto the stack by the instruction on offset 0x4D5 of the primary module,
then the serial generation algorithm begins. The serial generation algorithm can be broken down to the following steps:

1. Iterate through each character of the name, ignoring the last character.
2. If the character's ASCII value is between 0x41 and 0x5A, then a value of 0x2C is added to the modifier. If the character's ASCII value is not within that range, the modifier is incremented by the original ASCII value.
4. The modifier undergoes 4 changes; first it is incremented by 0x29A, then it is multiplied by 0x3039, then it is decremented by 0x17, then lastly it is multiplied by 0x9.
5. The algorithm repeatedly converts the remainder of the modified value divided by 0xA to its ASCII character representation, prepending it to the serial string, until the modified value becomes 0.
6. Lastly, the algorithm iterates over the characters of the input name, starting from the fourth character, and appends each character to the previously generated serial key.

## Sources
- [crackmes.one](https://crackmes.one/): The source of the original crackme. This site contains a rich repository of crackmes and other reverse engineering challenges. Highly recommended to improve your reverse engineering skills.

- [Guided Hacking - How to make a Key Generator KeyGen Tutorial](https://www.youtube.com/watch?v=rlM9JGx81xk): An in-depth guide on reversing the Ice9 crackme. I recommend checking it out for a visual step-by-step on how to reverse the serial generation algorithm.

- [Essential Keygen Music](https://archive.org/details/essential-keygen-music): A comprehensive collection of 100 chiptunes commonly used as keygen music. What's great about this archive is that the XM files appear to be direct rips from keygens, as their metadata is intact.

- [The XM file structure](https://aluigi.altervista.org/mymusic/xm.txt): A copy of the original documentation on the XM audio file format by Fredrik Huss. Was useful to get an understanding of how XM files are structured.

- [SharpMik](https://github.com/thegouldfish/SharpMik): A pure C# audio library that supports XM audio files. This was essential to getting the keygen to play the chiptune XM audio files.

- [Costura](https://github.com/Fody/Costura): A C# library that lets you embed references as resources. This library was very useful for embedding the SharpMik assembly references into the keygen's PE file.
