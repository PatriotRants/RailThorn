**RailThorn**  

A companion library to [*CrossWind*](https://github.com/PatriotRants/CrossWind). *RailThorn* builds on the foundational architecture that *CrossWind* lays.

Look into the Prototyping folder. The demo solution demonstrates an atchitecture similar to ***M-V-P***. Instead of a _presenter_, there is a _controller_.  
Some might see this as more similar to ***M-V-C***. It is ... just as ***M-V-P*** is. And it is. I use the *M-V-P* comparison because I want to ensure there is no confusion as to the target of this project. This project is more of a progression of the older proactices. Much like ***M-V-VM*** evolved for *WPF*, I am taking a new approach to an old problem.  

In the old days of building, designing, and developing **Windows Forms** (*WinForms*), and prior to the advent of *M-V-P*, code was thrown into the **`Form`**: events, business logic, database accessors, data models ... you name it, it was there, somewhere, all in one library. It was ugly. But that was the quick and dirty paradigm.  

Then came [***M-V-P***](https://www.geeksforgeeks.org/mvp-model-view-presenter-architecture-pattern-in-android-with-example/). It is a simple architecture to keep all the Window `Form` design separate from the other parts of a an application. To confine scope to where it belongs. It takes thought to create an application this way because every aspect or feature has it's place ... which is *not* sitting interweaved in the `Form`'s code behind.  

So ... here we are. I've been wanting to tackle something like this for quite some time. I want a cross-platform (Lin/Win) GUI development library for desktop applications. In addition, I want this library to be useful for game development.  
**RailThorn** is just a building block ... a tool. It *will* contain controls that can be placed into **OpenTK** windows. 

This library will likely grow very slow, in an organic manner. I don't know everything that will be in it because I don't know what I don't know.  

**The Plan**  
I am working on several projects at once - *CrossWind*, *RailThorn*, *GlowFork*, *SandPipe*, and *CobaltFox*. All of these culminate in the development of **ForgeWorks**. To get there, I am beginning the rewrite of *Infiniminer* using **OpenTK** and my libraries. 
Here's the way the projects break down:
 - **CrossWind**: [Repo](); see repo for more information. Briefly, it is the foundation that sets up the architecture I'm calling ***M-V-VC***.
 - **RailThorn**: Builds on **CrossWind** to further cement the ***M-V-VC*** architecture.
 - **GlowFork**: [Repo: TBA] a customizable game engine; more info as development progresses.
 - **SandPipe**: [Repo: TBA] a customizable *Voxel* engine; more info as development progresses.
 - **CobaltFox**: [Repo: TBA] a client/server library; more info as development progresses.

**Why?**  
Why not?

I put it this way: if I am constantly told to think outside the box, why am I even in a box? These are learning endeavors. They may or may not grow into something bigger and beyond what I might dream of. But, understand that these projects actually lay the foundation for something much larger and with a far broader scope than I can even get into here. This is a journey. I'm inviting you to come along and let's all get out of the box.
