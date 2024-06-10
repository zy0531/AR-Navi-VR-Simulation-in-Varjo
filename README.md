# AR-Navi-VR-Simulation-in-Varjo

## Introduction
This is the program of the experiment in paper **Y. Zhao, J. Stefanucci, S. Creem-Regehr and B. Bodenheimer, "Evaluating Augmented Reality Landmark Cues and Frame of Reference Displays with Virtual Reality," in IEEE Transactions on Visualization and Computer Graphics, vol. 29, no. 5, pp. 2710-2720, May 2023, doi: 10.1109/TVCG.2023.3247078.**

<img src="https://github.com/zy0531/AR-Navi-VR-Simulation-in-Varjo/blob/main/Figures/Illustration.png" width="60%" height="60%">

## Demo Video
https://www.youtube.com/watch?v=lrn_5SzA30U

## Hardware
- Varjo - XR3
- Base station x 2
- HTC Vive controller x 1
- HTC Vive tracker x1 (with a belt to tie the tracker in front of the belly of users)

## Software
- Varjo Base: version 3.2.0
- Unity 2020.3.20f1

## Scenes
- CScape/Assets/Scenes/Scene for Experiments
  
## System Design
<img src="https://github.com/zy0531/AR-Navi-VR-Simulation-in-Varjo/blob/main/Figures/SystemDesign.png" width="80%" height="80%">

## AR Display Simulation
In order to simulate the limited field of view that is common in AR HMDs, a plane was attached to the main virtual camera that mimicke an AR lens. It followed the movement of the camera at all times.
The plane was scaled to 60% of the camera’s original field of view. Additionally, we further simulated an AR display within the virtual environment by adding a degree of transparency to the virtual plane.
The alpha value of the plane was set to 60. 
[Customized shaders](https://github.com/zy0531/AR-Navi-VR-Simulation-in-Varjo/blob/main/CScape/Assets/Scenes/Portal.shader) with stencil buffers were used for rendering AR cues that could only be seen within the range of the simulated lens. Objects that were used to represented [AR cues](https://github.com/zy0531/AR-Navi-VR-Simulation-in-Varjo/blob/main/CScape/Assets/Scenes/BackObjects.shader) were assigned corresponding stencil referencing numbers to be displayed half transparently and in front of any other virtual objects regardless of the actual depth relationships.
<img src="https://github.com/zy0531/AR-Navi-VR-Simulation-in-Varjo/blob/main/Figures/ARSimulation.png" width="60%" height="60%">
