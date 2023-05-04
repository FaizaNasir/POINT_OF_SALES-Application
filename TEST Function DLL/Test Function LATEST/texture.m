function FV_TEXTURE = texture(image)
 
%Texture
P=rgb2gray(image);
FV_TEXTURE =statxture(P);
end