/* Class that should act as a library when parsing the BST XML files.
 * 
 * Copyright (C) 2014  Martin Jørgensen, http://flanker.dk
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along
 * with this program; if not, write to the Free Software Foundation, Inc.,
 * 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
 */

using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace BSTParser
{
    public class Parser
    {

        /// <summary>
        /// Loads a story from an XML file structured after the BST format.
        /// </summary>
        /// <param name="xmlFile">Path to the XML file.</param>
        /// <returns>A Story instance with the files content.</returns>
        public static Story LoadStory(string xmlFile)
        {
            if (!System.IO.File.Exists(xmlFile))
            {
                return new Story(); 
            }

            var doc = new XmlDocument();
            var story = new Story();
            var path = Path.GetDirectoryName(xmlFile);
            // Load the xml file into and XmlDocument class.
            doc.Load(xmlFile);

            // Retrieve variables and add them to the Vars hashtable.
            var vars = doc.GetElementsByTagName("var");
            for (var i = 0; i < vars.Count; i++)
            {
                var xmlNode = vars.Item(i);
                if (xmlNode == null) continue;
                if (xmlNode.Attributes != null)
                    story.Vars.Add(xmlNode.Attributes.Item(0).InnerText, xmlNode.InnerText);
            }

            // Get the story entry point.
            var beginningNodes = doc.GetElementsByTagName("story");
            var beginning = beginningNodes.Item(0); //Take item 0 since we only support one entry.
            if (beginning != null)
            {
                // Read the title and add it to the Story instance.
                if (beginning.Attributes != null)
                {
                    story.Title = beginning.Attributes.GetNamedItem("title").InnerText;
                }

                // Parse the branch info and add it to the Story instance.
                var beginningBranch = new Branch();

                // Images?
                var imgs = beginning.SelectNodes("img");
                if (imgs != null)
                {
                    for (var i = 0; i < imgs.Count; i++)
                    {
                        var xmlNode = imgs.Item(i);
                        if (xmlNode == null) continue;
                        if (xmlNode.Attributes != null)
                            beginningBranch.AddImage(path + "\\" + xmlNode.Attributes.GetNamedItem("file").InnerText,
                                xmlNode.InnerText);
                    }
                }

                // Text content
                var text = beginning.SelectSingleNode("text");
                if (text != null) beginningBranch.Text = text.InnerText;

                // Choices
                var choices = beginning.SelectNodes("choice");
                if (choices != null)
                {
                    for (var i = 0; i < choices.Count; i++)
                    {
                        var choice = choices.Item(i);
                        if (choice == null) continue;
                        if (choice.Attributes != null)
                            beginningBranch.AddChoice(choice.InnerText,
                                choice.Attributes.GetNamedItem("target").InnerText);
                    }
                }


                // Add it to the Story instance
                story.Beginning = beginningBranch;
            }

            // Move on to the branches, basically same as above, but with and id attribute instead of title.
            var branches = doc.GetElementsByTagName("branch");
            for (var i = 0; i < branches.Count; i++)
            {
                // Parse each branch.
                var branch = new Branch();
                var branchNode = branches.Item(i);
                if (branchNode == null) continue;

                // Parse images
                var imgs = branchNode.SelectNodes("img");
                if (imgs != null)
                {
                    for (var j = 0; j < imgs.Count; j++)
                    {
                        var xmlNode = imgs.Item(j);
                        if (xmlNode == null) continue;
                        if (xmlNode.Attributes != null)
                            branch.AddImage(path + "\\" + xmlNode.Attributes.GetNamedItem("file").InnerText,
                                xmlNode.InnerText);
                    }
                }

                // Parse text
                var text = branchNode.SelectSingleNode("text");
                if (text != null) branch.Text = text.InnerText;

                // Parse choices
                var choices = branchNode.SelectNodes("choice");
                if (choices != null)
                {
                    for (var j = 0; j < choices.Count; j++)
                    {
                        var choice = choices.Item(j);
                        if (choice == null) continue;
                        if (choice.Attributes != null)
                            branch.AddChoice(choice.InnerText,
                                choice.Attributes.GetNamedItem("target").InnerText);
                    }
                }

                // Add it to the story.
                if (branchNode.Attributes != null) story.Branches.Add(branchNode.Attributes.GetNamedItem("id").Value, branch);
            }
            return story;
        }
    }
}
