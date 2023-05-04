function [O1,O2,O3] = Opponent(in)

R=double(in(:,:,1));
G=double(in(:,:,2));
B=double(in(:,:,3));


O1=(R-G)./sqrt(2);
O2=(R+G-2.*B)./sqrt(6);
O3=(R+G+B)./sqrt(3);
