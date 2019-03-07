# Prism Example

This is the source code for [my and Learn Programming Academy's Advanced Xamarin Masterclass on Udemy](https://www.udemy.com/the-advanced-xamarin-developer-masterclass/?couponCode=GITHUB)

This is a *Read Books* application that uses the [Goodreads API](https://www.goodreads.com/api) to search for books by Author, Title or ISBN.

Books can later be saved into a local SQLite database, retrieved, listed, and have their details shown.

## Lecture's Source code

Check the branches for the source code for each lecture seen in the course. Each branch contains the state of the project by the end of the corresponding lecture.
Notice the naming to identify the corresponding branch: AdvXamarin-[Some_Number]- [Lecture_Name]

## Branches

- **AdvXamarin-1320-PrismSetup**: During this lecture you will reference the necessary packages to start using the Prism framework with Unity, and setup the three projects that exist in the solution to use Prism
- **AdvXamarin-1340-ViewsAndVMs**: In this lecture you will define the views and the view models that we will need to list the read books, add new books to the list, and display the details for selected books. finally you will relate the views to their respective view models in the way that Prism requires, by registering the types fpr navigation
- **AdvXamarin-1360-PrismNavigation**: Registering the views with their corresponding view models with the Prosim Application Register types method helps establish the required bindings. Dependency Injection will help us use the Navigation Service from the view model. Now, everything that we need is for the navigation to execute when a certain new delegate command is executed
- **AdvXamarin-1380-SearchBooks**: In this lecture we will use the Goodreads API and search for books by name, author and ISBN, we will then bind the command and the command parameter of a search bar to the view model and learn a new way to bind from a property that exists in the current reference
- **AdvXamarin-1400-SaveBooks**: In this lecture you will implement the functionality that inserts and reads books into a local database using SQLite, reacts to commands that fire from buttons, and list the read elements from both the database and the REST API into ListViews using the Observable collection. Finally you will use Prism to implement the OnAppearing directly from the View Model.
- **AdvXamarin-1420-EventToCommand**: Not all events have a version that can be bound to a command, like the click of a button. If we want to use the MVVM pattern with an event, we may need to write at least a bit of code in the code behind, unless you are using Prism. So in this lecture we use a behavior available through Prism to create a command out of an event.
- **AdvXamarin-1440-NavigationParameters**: In this lecture we will pass some parameters to another page when navigating using Prism. The previous way isn't possible because navigating with Prism makes no use of the Page's constructor. We will also need to use an interface that will expose new members that react to navigation events: we need navigation awareness.

Consider visiting the [course](https://www.udemy.com/the-advanced-xamarin-developer-masterclass/?couponCode=GITHUB) for access to tutorials on using Prism based on this code.
