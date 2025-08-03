# Hotel Portal - Blazor C# Web Application

A comprehensive web application built with Blazor Server and C# for hotel registration and menu management. This application allows hotel owners to register their properties and manage their restaurant menus efficiently.

## 🏨 Features

### Hotel Management
- **Hotel Registration**: Complete hotel registration with detailed information
- **Hotel Listing**: View all registered hotels with search and filter capabilities
- **Hotel Details**: Comprehensive hotel information display
- **Hotel Status Management**: Active/Inactive status control

### Menu Management
- **Menu Item Creation**: Add detailed menu items with nutritional information
- **Category Management**: Organize items by categories (Appetizer, Main Course, Dessert, etc.)
- **Dietary Options**: Support for Vegetarian, Vegan, and Gluten-Free items
- **Price Management**: Set and display item prices
- **Availability Control**: Mark items as available or unavailable

### User Features
- **Authentication**: Secure user registration and login
- **Authorization**: Protected routes for authenticated users
- **Responsive Design**: Modern, mobile-friendly interface
- **Real-time Notifications**: Toast notifications for user actions
- **Search & Filter**: Advanced filtering capabilities

## 🛠 Technology Stack

- **Framework**: ASP.NET Core 8.0 with Blazor Server
- **Database**: SQLite with Entity Framework Core
- **Authentication**: ASP.NET Core Identity
- **UI Framework**: Bootstrap 5.3
- **Icons**: Font Awesome 6.4
- **Notifications**: Blazored Toast
- **Styling**: Custom CSS with modern design patterns

## 📁 Project Structure

```
HotelPortal/
├── Data/
│   └── ApplicationDbContext.cs     # Entity Framework context
├── Models/
│   ├── Hotel.cs                    # Hotel entity model
│   └── MenuItem.cs                 # Menu item entity model
├── Pages/
│   ├── Hotels/
│   │   ├── Index.razor            # Hotels listing page
│   │   └── Create.razor           # Hotel registration form
│   ├── MenuItems/
│   │   ├── Index.razor            # Menu items listing page
│   │   └── Create.razor           # Menu item creation form
│   ├── Index.razor                # Home page
│   ├── Error.cshtml               # Error page
│   └── _Host.cshtml               # Host page
├── Shared/
│   ├── MainLayout.razor           # Main layout component
│   ├── NavMenu.razor              # Navigation menu
│   ├── LoginDisplay.razor         # Login display component
│   └── RedirectToLogin.razor      # Login redirect component
├── wwwroot/
│   └── css/
│       └── site.css               # Custom styles
├── Program.cs                     # Application startup
├── _Imports.razor                 # Global imports
└── HotelPortal.csproj            # Project file
```

## 🚀 Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Any code editor (Visual Studio, VS Code, etc.)

### Installation

1. **Clone or download the project files**

2. **Navigate to the project directory**
   ```bash
   cd HotelPortal
   ```

3. **Restore dependencies**
   ```bash
   dotnet restore
   ```

4. **Build the application**
   ```bash
   dotnet build
   ```

5. **Run the application**
   ```bash
   dotnet run
   ```

6. **Open your browser and navigate to**
   ```
   https://localhost:5001
   ```

### First Run

1. **Register a new account** using the Register link
2. **Login** with your credentials
3. **Register your first hotel** using the "Register Hotel" button
4. **Add menu items** for your hotel using the "Add Menu Item" button

## 📊 Database

The application uses SQLite database with Entity Framework Core. The database is automatically created on first run with seed data:

### Seed Data Includes:
- **2 Sample Hotels**: Grand Palace Hotel and Cozy Inn
- **3 Sample Menu Items**: Various dishes with different dietary options

### Database Schema:
- **Hotels**: Hotel information and properties
- **MenuItems**: Menu items linked to hotels
- **AspNetUsers**: User authentication data

## 🎨 UI Features

### Modern Design
- **Responsive Layout**: Works on desktop, tablet, and mobile
- **Card-based Interface**: Clean and organized content display
- **Gradient Backgrounds**: Modern visual appeal
- **Smooth Animations**: Enhanced user experience
- **Icon Integration**: Font Awesome icons throughout

### User Experience
- **Search & Filter**: Quick finding of hotels and menu items
- **Real-time Validation**: Form validation with immediate feedback
- **Loading States**: Visual feedback during operations
- **Toast Notifications**: Success and error notifications
- **Preview Features**: Live preview of hotels and menu items

## 🔐 Security Features

- **ASP.NET Core Identity**: Secure user authentication
- **Authorization Attributes**: Protected routes and components
- **Input Validation**: Client and server-side validation
- **SQL Injection Protection**: Entity Framework parameterized queries

## 🌟 Key Functionalities

### Hotel Registration
- Complete hotel information capture
- Star rating system (1-5 stars)
- Contact information management
- Image URL support
- Active/Inactive status control

### Menu Management
- Comprehensive menu item details
- Category-based organization
- Nutritional information (calories, preparation time)
- Dietary restriction indicators
- Allergen information
- Price management

### Search & Filter
- Hotel search by name, description, city, country
- Filter by city and star rating
- Menu item search by name, description, category
- Filter by hotel, category, and availability

## 📱 Responsive Design

The application is fully responsive and works seamlessly across different devices:
- **Desktop**: Full sidebar navigation with expanded content
- **Tablet**: Adapted layout with optimized spacing
- **Mobile**: Collapsible navigation with touch-friendly interface

## 🔧 Configuration

### Database Connection
The application uses SQLite by default. The connection string can be modified in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=hotelportal.db"
  }
}
```

### Identity Settings
Password requirements and other identity settings can be configured in `Program.cs`.

## 🚀 Deployment

### Development
```bash
dotnet run
```

### Production
```bash
dotnet publish -c Release
```

## 🤝 Contributing

1. Fork the project
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Open a pull request

## 📄 License

This project is available for educational and personal use.

## 📞 Support

For questions or support, please refer to the application's help section or contact the development team.

---

**Built with ❤️ using Blazor Server and C#**