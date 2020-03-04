# Movie List Basic Challenges
## More Fields
Add additional fields for Director, Length, and Genre. You will need to:

1. Add the `TextBlock`s and `TextBox`es to the User Interface
1. Add the fields to the `Movie` class
    - Note that Length should be an `int`
1. Add parameters to the `Movie` constructor, and initialize the fields
1. Add the new fields to the `ShowDetails` method so the information is shown to the user

## Styles
Read this article to familiarize yourself with WPF styles: https://docs.microsoft.com/en-us/dotnet/framework/wpf/controls/styling-and-templating

Then, add some styles to your WPF to make your application look great! You can change any styles you'd like, but at least change the font size, font family, text color, and background color for the buttons. After that, feel free to change anything else.

## Movie Poster
Add a poster image to each Movie. This should be another field on the `Movie` class (and in the UI) that will hold the filename of the image (e.g., `"C:\\Dog.jpg"`).

In the UI, add a button labeled "Next Movie" that will cycle through all of the movie posters when clicked. Under the button, there should be a `<TextBlock>` that says the name of the current movie, and an `<Image>` that displays the poster.

Use the internet to help figure out how to update a WPF Image from the filesystem.