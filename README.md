BranchingStoryTools
===================

A project I'm doing for fun, learning C#/XML interaction and usage. Also, just getting familiar with C#.
Don't want to put too much crappy code in the FEngine project. :)

Flankers BST/XML Format
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
should have one attribute: ```title```. So an empty story with an entry point will look like this

```XML
<?xml version="1.0" encoding="utf-8" ?>
<forest>
  <story title="Documenting my stuff.">
  </story>
</forest>
``` 