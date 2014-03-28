BranchingStoryTools
===================

A project I'm doing for fun, learning C#/XML interaction and usage. Also, just getting familiar with C#.
Don't want to put too much crappy code in the FEngine project. :)

Martins BST/XML Format
-----------------------

So I'll try to document the XML format, I don't expect anyone to use it, but it's good practice for me,
and it might prevent me from forgetting it, and maybe learn how to use markdown. Sounds good enough for me.
So lets get started!

So like every XML document we need the pesky standard header.

```XML
<?xml version="1.0" encoding="utf-8" ?>
```

The root element in the format is simply called ```<forest> ... </forest>``` and have no properties,
it's just there to let us enjoy the XML standard, and to provide a root in the XPATH. (Am I getting it
right so far?) The only real obligatory element in the root is the ```<story> ... </story>``` element,
which acts as an entry-point into the story, a place for the parser to start. The ```<story>``` element
should have one attribute: ```title```. Also: you may only ever have a single ```<story>``` element
in the file, since multiple beginnings are not planned, yet :)
So an empty story with an entry point will look like this

```XML
<?xml version="1.0" encoding="utf-8" ?>
<forest>
    <story title="Documenting my stuff.">
    </story>
</forest>
```

This makes for a dull story. The idea was to have a format that allows for images to be "attached" to certain
parts of the story, and for the story to branch based on choices, this introduces 3 new sub-elements ```<img>```,
```<text>``` and ```<choice>```. The purpose of each should be painfully obvious, so lets add them right into
the example!

```XML
<?xml version="1.0" encoding="utf-8" ?>
<forest>
    <story title="Documenting my stuff.">
        <img file="img/happy.jpg">Description</img>
        <text>
            So whatever text we want to make someone read goes on here.
            Imagine that this text gave you a choice on how to proceed, please.
        </text>
        <choice target="nope">Absolutely not</choice>
        <choice target="hellyeah">Sure can do!</choice>
    </story>
</forest>
```

So lets start with the ```<img>``` element, it have a single attribute, which is the relative path to the image we
want to associate with the text, and an innervalue containing an optional description of the image (can contain variables, see below).
The ```<text>``` element have no attributes and the inner value is simply the text for this section of the story.
The ```<choice>``` element have a single attribute, which is the ID of the branch it should proceed to (I'll come to
this in a minute, trust me) and an innervalue that is a labeltext for the choice (used for a button or something).
A ```<forest>``` can contain any number of branches, as long as their ID is unique. A pair of branches  in the story
can look like so

```XML
<?xml version="1.0" encoding="utf-8" ?>
<forest>
    <story title="Documenting my stuff.">
        <img file="img/happy.jpg">Description</img>
        <text>
            So whatever text we want to make someone read goes on here.
            Imagine that this text gave you a choice on how to proceed, please.
        </text>
        <choice target="nope">Absolutely not</choice>
        <choice target="hellyeah">Sure can do!</choice>
    </story>

    <branch id="nope">
        <img file="img/wink.jpg">A winky face</img>
        <img file="img/wink2.jpg">Another winky face</img>
        <text>Got you, it did! ;)</text>
    </branch>

    <branch id="hellyeah">
        <text>Thanks, I like you!</text>
    </branch>
</forest>
```

The ```<branch>``` element can contain the same sub-elements as a ```<story>``` element, but forgoes the
```title``` attribute in favour of the ```id``` attribute the ```<choice>```elements use to link to a new
branch. Pretty nifty. Both ```<story>``` and ```<branch>``` elements are allowed multiple ```<img>``` and
```<choice>``` sub elements, but only one ```<text>``` sub element.

Note that the story have every chance to go into an infinite loop, this is on purpose, as it allows for reuse
of text if needed. Any branch that do not have a choice will be considered an end of the story.

For added interactivity I added another sub element for the ```<forest>``` element called vars. It's used for
specifying variables that the user/reader must fill in at load-time. It's use is fairly straightforward as is
seen in the below example.

```XML
<?xml version="1.0" encoding="utf-8" ?>
<!--
    Example XML story file for use with BST software. :)

    Copyright (C) 2014  Martin Jørgensen, http://flanker.dk

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
-->
<forest>
    <vars>
        <var id="MainChar">Donatello</var>
        <var id="SideChar">Michaelangelo</var>
        <var id="Place">Ancient China</var>
    </vars>

    
    <story title="Turtles in China">
        <img file="img/wall.jpg">The great wall of China.</img>
        <text>
            The two turtles went for a walk in %Place. Suddenly %SideChar wanted
            a pizza.
        </text>
        <choice branch="nopizza">Hell no!</choice>
        <choice branch="muchpizza">Great idea!</choice>
    </story>

    <branch id="nopizza">
        <img file="img/sadturtle.jpg">A sad turtle face.</img>
        <text>
            %MainChar slapped %SideChar and asked him to focus on the mission at hand.
            It would be hard enough without them waddling around full of pizza.
        </text>
        <choice target="segway">Lets go!</choice>
    </branch>

    <branch id="muchpizza">
        <img file="img/happyturtle.jpg">A happy turtle.</img>
        <img file="img/deliciuspizza.jpg">The pizza the happy turtly is enjoying.</img>
        <text>
            Agreeing, %MainChar sniffed up the closest pizza joint and set about eating with his friend.
        </text>
        <choice target="segway">Now lets go!</choice>
    </branch>

    <branch id="segway">
        <text>
            Arriving at the fortress, the two turtles decided to take a sneaky approach..
        </text>
    </branch>
</forest>
```

The ```<var>``` element specifies an attribute which is it's id, this will be used for replacing text in the
inner value if ```<img>```, ```<text>``` and ```<choice>``` elements. The id should not contain anything
but letters(upper- and lowercase) and numbers. In order for a variable to be used in another element, it must
be marked witth ```%VarId```. Above I used variables for the main person, the side character and a place.

This should be sufficient to allow me to remember the format I wanted to implement, and hopefully any (though I doubt
there will be any) readers will have gotten the gist too.

The last example is also found in [TestStory.xml](TestStory.xml).