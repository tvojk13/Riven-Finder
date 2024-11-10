# Riven Finder

### What is it?
Riven Finder is a companion app for Warframe that automates the process of searching for Riven mod auctions on the Warframe.market platform. Its main goal is to assist players in finding the best deals for specific Riven mods, using search parameters like maximum price and seller status.

### How does it work?
The app lets players create custom search tasks for Riven mods, which it then actively monitors on the marketplace. Each task can specify weapon type, max buyout price, and seller status preferences. Once configured, Riven Finder sends automated API requests to Warframe.market, retrieves auction data, and displays the most relevant results in a user-friendly format within the app. This way, players get up-to-date auction information directly within the Riven Finder interface, saving time and effort.

### Installation
1. Follow this [link to the releases page](https://github.com/tvojk13/Riven-Finder/releases) and download the latest release.
2. Extract the archive and run `Riven-finder.exe`.
3. Make sure to install the **.NET Framework 6.0**.

### Requirements
- Warframe account (login credentials required for accessing Warframe.market API)

### Features
#### Task Creation
Riven Finder lets users set up specific search tasks for Riven mods by selecting criteria like:
- **Weapon Type**
- **Max Buyout Price**
- **Seller Status (Online/Offline/All)**

#### Auction Monitoring
The app continually updates and checks all active tasks every few seconds, providing notifications when items that meet the specified criteria are found. Each task’s status can be managed directly in the app.

#### Task Management Interface
Users can easily edit, pause, delete, and update tasks:
- **Pause/Resume Tasks** - Temporarily stop or restart a task.
- **Edit Tasks** - Modify task parameters.
- **View Auction Details** - Detailed window view for any matching auction listings.
  
#### Automated Auction Fetching
The app automatically fetches the latest Riven auctions based on active tasks, so players don’t need to refresh manually.

### Example Usage
1. Open **Riven Finder** and log in using your Warframe.market credentials.
2. Click on **Create Task** to define a search for a Riven mod with criteria like weapon type and max price.
3. Start the search, and the app will display any matching Riven auctions it finds.
4. When an auction that matches your criteria is found,  the item details will be shown.

### Contact Us
Have questions or suggestions? Feel free to reach out!  
Email: tvojk13@gmail.com
