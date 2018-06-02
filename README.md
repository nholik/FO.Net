# FO.NET

Originally from the project https://archive.codeplex.com/?p=fonet

This was cloned from https://github.com/Mimeo/Fo.Net

XSL-FO to PDF renderer written in managed C# code for the .NET framework

Several years ago, I made some (small) updates to fix some race conditions when using this in a multi-thread scenario and a few updates to make the image handler function a little easier to use.  My updates are thrown on top so that they can be seen in the commit history on the off-chance someone actually wants to use this.

### Prerequisites

This was last tested to build with Visual Studio 2017, but you can probably go all the way back to 2013

### About
In all probability, noone will use this and I don't expect to make any updates.  But if you're here...

XSL-FO is (was?) a specification primarily for generating pdfs from XML data [see here](https://en.wikipedia.org/wiki/XSL_Formatting_Objects).  I found this library to be the best choice given no budget and certain circumstances related to XML-fandom both beyond my control.  I must say though that XSL is actually a fun declarative language and this library gets the job done.

Given that as of 2013 the W3C closed XSL-FO, what little interest there was is probably gone.  Though depending on who you talk to, if it is someone with significant investment in the technology he or she might argue that it is closed because it is feature complete and does everything and therefore no need to continue.

## License

This project is licensed under the Apache License 2.0 - see the [LICENSE](LICENSE) file for details




