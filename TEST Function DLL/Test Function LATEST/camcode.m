
function image = camcode()
%clear all; close all; clc;
vid = videoinput('winvideo',1,'YUY2_640x480'); %vid object 
                                                %video adapters
                                                %Resolution
                                                %1 frame per trigger
                                                
[y,Fs] = audioread('camerashot.wav');           %reading camera sound 
%vid.FramesPerTrigger= 1;`
vid.ReturnedColorspace = 'rgb';                %RGB color
%preview(vid);                                        
pause(4.0);                                     %pause of 4 sec to capture snapshot
sound(y,Fs);                                    %play camera click sound
image=getsnapshot(vid);                         %store snapshot in a varaible
%imshow(image);                                  %show the snapshot

imwrite(image,'image.jpg');                     %save captured image as "image.jpg" 
closepreview(vid);                                                  
end