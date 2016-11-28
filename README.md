# piano_AR

This project explores the intersection of education and Augmented Reality through the development of a piano tutoring HoloLens application which generates a visual falling note representation of the music. The falling notes are overlaid on a MIDI keyboard which allows the user to play along while recieving visual feedback from the simulation.

A screengrab of the standalone is shown below

![demo image](https://github.com/honeyimholm/piano_AR/blob/master/piano_AR_screenshot.png)

# Process

• This MIDI file is then fed into a MIDI to piano roll matrix converter which represents key press timing with 10Hz/88 key granularity.

• This timing matrix is used to create a falling visual representation of the notes projected onto a MIDI
keyboard that allows the user to both see which keys are active and prepare for incoming notes. 

• The user input to the MIDI keyboard is relayed to the HoloLens simulation which then provides
visual feedback by highlighting the key green if the key has been correctly pressed and red if it has
been incorrectly pressed or missed.

• The user is also given audio feedback by distorting the correct audio of the song proportionally to
how many incorrect keys are being pressed or correct keys missed. 

There are a lot of files that I should probably delete - key files to look at are:




# Demo

The easiest way to try out this project is to run the [standalone exe](https://github.com/honeyimholm/piano_AR/blob/master/AR_standalone_demo.exe)

Make sure you download the AR_standalone_demo_Data file as well

If you have access to a HoloLens or HoloLens emulator you can download the Assets and Library Files. 
