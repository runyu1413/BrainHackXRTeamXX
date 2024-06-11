# HoloLens Sustainability App

## Team Name
XX

## Installation and Usage Instructions

### Prerequisites
- Unity 2020.3 or later
- MRTK (Mixed Reality Toolkit) v2.7 or later
- Visual Studio 2022 or later

### Installation
1. **Clone the Repository:**

2. **Open in Unity:**
   - Open Unity Hub.
   - Click on "Add" and select the cloned project directory.
   - Open the project in Unity.

3. **Import MRTK:**
   - If MRTK is not already imported, go to the Unity Asset Store, download, and import MRTK into the project.

4. **Build Settings:**
   - Go to `File > Build Settings`.
   - Switch the platform to `Universal Windows Platform (UWP)`.
   - Set Architecture to be `ARM 64-bit`.

### Usage

1. **Deploy to HoloLens:**
   - Connect your HoloLens device to your development machine.
   - Go to `File > Build Settings`.
   - Click on `Build` and select a directory for the build.
   - Open the generated solution in Visual Studio.
   - Deploy the application to your HoloLens device (ARM64 configuration, Device target).

2. **Running the App:**
   - Put on the HoloLens device.
   - Launch the app from the Start menu.
   - Use the HoloLens camera to scan the Singapore Eco-Labels.
   - Information about the scanned labels will be displayed in augmented reality.

## Development Tools Used
- **Unity 2020.3**: Game engine used for developing the HoloLens application.
- **MRTK (Mixed Reality Toolkit) v2.7**: Provides components and features for developing mixed reality applications.
- **Visual Studio 2022**: IDE for building and deploying the UWP application.

## Licensing
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
