
function img = webcam_app(baseDir_arg)
counter = 1;
vid = videoinput('winvideo',1,'YUY2_640x480');  
[y,Fs] = audioread('camerashot.wav');
vid.ReturnedColorspace = 'rgb';
src_size = get(0,'screensize'); %The screen size
width = src_size(3);
height = src_size(4);
%figure('Units', 'pixels', 'Position', [100 100 340 260]);
set(figure,'Position',[width-300, height-200, 300, 200]);


vidRes = get(vid, 'VideoResolution');
nBands = get(vid, 'NumberOfBands');
hImage = image( zeros(vidRes(2), vidRes(1), nBands) );
preview(vid, hImage);
pause(5.0);
sound(y,Fs);

img=getsnapshot(vid);
closepreview(vid);
%imshow(img);
if nargin == 0
    baseDir = 'C:\Users\Public\Pictures\Sample Pictures';
     baseName = 'image_'; 
    newName = fullfile(baseDir, sprintf('%s%d.jpg', baseName, counter));
else
    baseDir = baseDir_arg;
    baseName = 'image_'; 
    newName = fullfile(baseDir, sprintf('%s%d.jpg', baseName, counter));
end

while exist(newName,'file')
counter = counter + 1;
newName = fullfile(baseDir, sprintf('%s%d.jpg', baseName, counter));
end
imwrite(img, newName);
close all;

end