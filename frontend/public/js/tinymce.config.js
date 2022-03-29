tinymce.init({
    language: "pt_BR",
    selector: "#body",
    plugins: [
        "advlist " // extends the core bullist and numlist toolbar controls by adding CSS list-style-type styled number formats and bullet types to the controls
        +
        "autolink " // automatically creates hyperlinks when a user types a valid, complete URL
        +
        "autoresize " // automatically resizes the editor to the content inside it
        +
        "codesample " // lets a user insert and embed syntax color highlighted code snippets into the editable area
        +
        "emoticons " // adds a dialog to the editor lets users insert emoji 
        +
        "fullscreen " // adds full screen editing capabilities
        +
        "hr " //  allows a user to insert a horizontal rule on the page at the cursor insertion point
        +
        "image " // enables the user to insert an image
        +
        "imagetools " //adds a contextual editing toolbar to the images in the editor
        +
        "insertdatetime " // lets a user easily insert the current date and/or time
        +
        "link " // allows a user to link external resources such as website URLs
        +
        "lists " // allows you to add numbered and bulleted lists
        +
        "media " // adds the ability for users to be able to add HTML5 video and audio elements 
        +
        "paste " // filter/cleanup content pasted from Microsoft Word.
        +
        "preview " // adds a preview button that opens a dialog box showing the current content in a preview mode
        +
        "print " // adds a print button 
        +
        "save " // adds a save button to download content
        +
        "searchreplace " // adds search/replace dialogs 
        +
        "table " // dds table management functionality
        +
        "wordcount" // adds counting of words on the right edge of the status bar
    ],
})