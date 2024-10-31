Concept :
Take a list of song names and add some infos via an API to finally sort in by artist/album in a txt file.
More infos will be given after the instructions.

Steps :
1. Manually create a list of 50 tracks from various artists. (with only name AND name + artist name) as per the example Track_List.txt

2. Create a code that will read in this file the songs and add a list of songs (from a class track) with only the name OR name + artist name.

3. Through this list of tracks, examine and compare to an online API with informations (artist, album, year) 
and complete de track infos with it (thoses infos in the objects track were empty and call be filled now).

((Optionnal)) 3*. If the same track name have several artists possible, ask the user in console to pick one. 
(Ex : There was several matches for the track "What is Love ?" which one do you want : 1. By Clean Bandits 2. by TWICE 3. by James Young) <- the user will type 1,2 or 3 and press enter.
Accordingly, update the infos from the wanted track.

if you don't do 3*, if there is several results just take the first one returned (see FirstOrDefault<> of SingleOrDefault<>)

4. Create the artist if it doesn't already exists, then same with the album (you should create a default "no artist" artist and "no album" album per artist)

5. Add the track to your newly created arstist and album or already existing ones

6. Once finished, create a txt in the output folder with the format sorted_tracklist_dd/MM-hh:mm.txt 
thats sorts all the tracks by album and artist according to the template given Sorted_Track_List.txt


Infos : 
The mandatory classes have been created, it's Track.cs, Album.cs, Artist.cs, you'll have to fill them, the class Track.cs have some code already written to give you a template.

The part where the first initialization if just name OR name + artist name will actually create a lot of complexity, you can skip ip by just putting the name and filling the artist everytime with the API

You have a template for the input and output tracklist in the respective folders, use them as guide but feel free to change it however you want,
this is just an example you can list the tracks differently and sort them differently.

You may or may not use a database, this is not necessary nor mandatory but can be done with it.

You will have to fill the tracks yourself and find the API yourself, if you struggle with finding the API just tell me and we'll look for it together.

Don't hesitate to ask a question, but before you do, try something and ask google (stackoverflow is your best friend).

LAST THING : Try to use the team explorer in visual studio to commit your code on git, it's a powerful tool that should be used. (if you're lost with the tool ask me)

Good luck (luck ain't nothing to do with that tho)
