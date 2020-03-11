### Adding the List View
1. Change the `List` of Movies to an `ObservableCollection`
1. Change `Title` and `ReleaseYear` to properties (instead of regular fields)
1. Add the `ListView` to the XAML file, giving it a Name, Height, Margin
1. Add the `ListView.View` and `GridView` inside the `ListView`
1. Add `GridViewColumns` for each property on the Movie (Title and Release Year)
    - Explain that the `Binding` specifies which property from the object will appear in the given column
1. In the `MainWindow` constructor, set the `ItemsSource` for the `ListView` to be the observable collection of Movies

### Adding the Double Click
1. In the XAML, in the `ListView` tag, start typing "MouseDoubleClick" and generate the event handler
1. In the `.cs` file, fill out the MouseDoubleClick method.
    - Get the selected movie using `SelectedItem` and cast it as a `Movie`
    - If the `Movie` is not null, show the details for the movie