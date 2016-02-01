# InfoStash

**TODO LIST**
- [ ] Setup Rally or something similar to manage the project
- [ ] I am using Xamarin Studio but anythign will work I believe
- [ ] Create project layout
  - [ ] Have a core that can be reused by any OS. Android, IOS maybe even Web.
  - [ ] Investigate the best way to separate the projects. Do we need Core, Infrastructure? What about Dependency Injection?
- [ ] Setup up object model classes. I don't think code first is an option but let's be sure.
- [ ] Setup database. Do we use Azure? What about sqllite or even nosql? Investigate best option.
- [ ] Get a basic version of our app running. Just dummy code.
- [ ] Figure out how to deploy the app to our phones for testing. 
- [ ] Setup devices that we want to support. Do we have different builds for each device or can we program it to work on all? Is there some kind of responisve for it?


** Here is the idea **
An app that will keep information about various thing in an organized fashion and for easy retrieval when needed. The app should be able to be shared amongst multiple people. You should also be able to share specific items with other people in an easy way. For instance you can choose to make another person an admin and share your account(spouse?), you grant someone access to everything or a portion of your categories (read only, write, admin?) or you can send someone via other method(email, text, etc) a specific item or category.

A large portion of this should be free but if you want advanced features like sharing, or sending items, then that should be the paid version. We could also limit the amount of items you can add, or even limit to a single category(house, person, misc.) in the free version. Ads on Free version?

Each item added should have: 
1.	Top level category (House, Person, Misc)
2.	Sub level category –During setup they can choose which categories they want and name them. At any time they can add new categories. They may choose to add a Kids Bedroom and name it Katie’s Room to House or add a child to Person and name her Katie.
3.	Object Category (Need new name for this) – this is the item you want to save info about. For a bedroom you may have light and save the wattage, color or brand you want. For a person it may be Shoe size or music, etc. You can always just add new objects or just a miscellaneous note.

Some things might be time sensitive like a childs pant size. In that case you should be able to warn or expire that information.
You should also be able to archive something’s like a house, when you move.

We will have default options below that have images and suggested items.
* House
  * Room
    * Living Room
    * Family Room
    * Garage
    * Bathroom
    * Kids Bedroom
    * Master Bedroom
    * Guest Bedroom
    * Office
    * Backyard
    * Front yard
  * Object Category               
    * Light
    * Title
    * Watts
    * Color
    * Brand
    * Price
  * Wall
    * Title
    * Dimensions
    * Paint
  * Window
    * Size
    * Type
  * AC Filter
    * Size
    * Type
    * Brand
  * Person
    * Child(Girl)
    * Child (boy)
    * Man
      * Pant Size
      * Shirt Size
      * Shoe Size
      * Ring Size
    * Woman
    * Grandmother
    * Grandfather
  * Miscellaneous
  
  ** object/class/table ideas **
  master_main_catagories *holds the default master category list*
  master_sub_categories *holds the default master subcategory list*
  master_objects *holds the default master object list*
  master_object_fields *holds the default master list of fields for an object*
  user *registered users*
  user_main_catagories *holds the users selected main categories*
  user_sub_categories *holds the users selected sub categories*
  user_objects *holds the users selected objects*
  user_object_fields *holds the users selected fields*
  
  Data would be transferred from the master table to the user table when it is used but it would also be linked via id. That way the users could customize naming, etc. If there is no idea assoicated then it would be assumed to be a custom category/object/field. This would also allow us to change the master list as we want without affecting current users.
