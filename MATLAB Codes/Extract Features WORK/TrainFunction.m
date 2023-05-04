function Training = TrainFunction(N1,alpha,epoch)
load ('INPUT_FEATURES.mat'); %importing Input Features
load('OUTPUTS.mat'); %importing Actual Outputs




p=1;   % to control randomness of weights
[row col] = size(INPUT_FEATURES);
inp = col;
%inp=30; %Number of Inputs / Features
%N1=20;  %Number of Neurons
N2=1;     %Output Layer Neuron
%alpha=0.09;    %the learning rate
%epoch= 100; %Number of epochs
maxVec = max(INPUT_FEATURES); %max of each column in INPUTs
minVec = min(INPUT_FEATURES); %min of each column in INPUTs
[row col]=size(INPUT_FEATURES); % total number of Rows & Columns of INPUTs or Dimension of INPUTs




for x=1:row
    %NORMALIZING inputs from -1 to 1
   INPUT_FEATURES(x,:) = ((INPUT_FEATURES(x,:)-minVec)./(maxVec-minVec) - 0.5 ) *2;
end




w1=randn(N1,inp)/sqrt(N1*p); %Random weights from inputs to hidden layer neurons
w2=randn(N2,N1)/sqrt(N2*p);  %Random weights from hidden layer neurons to output layer neuron


b1=zeros(N1,1); %filling the hidden layer biased values matrix with zeroes
b2=zeros(N2,1); %filling the Output layer biased values matrix with zeroes


for k=1:epoch       %1 to total # of epochs 
   I(k)=0;          %initially sum of error = 0
   ind=randperm(length(INPUT_FEATURES));  %random permutations till length of INputs
 
    for i=1:length(INPUT_FEATURES)  %for all inputs
    
        n1=w1*INPUT_FEATURES(ind(i),:)'+b1;   %hidden layer neuron value       
        a1=logsig(n1);  %activation hidden layer
        
        n2=w2*a1+b2;  %output layer neuron value
        a2=purelin(n2);    % activation output
        
        out(i)=round(a2);  %Round off predicted output
         
        e=OUTPUTS(ind(i))-a2; %actual - prdicted
        I(k)=I(k)+e*e';        %Sum of Error
    
        Y2=2*dpurelin(n2,a2)*e; %Sigma for Output layer
        %dpureline = (N,A);
        %where
        %N = Input
        %A = pureline(N)
        
        Y1=diag(dlogsig(n1,a1),0)*w2'*Y2; %Sigma for Hidden Layer
        %dlogsig = (N, A);
        %where
        %N = Input
        %A = logsing(N)
        
        
        w2=w2+alpha*Y2*a1';   %updating weights
        w1=w1+alpha*Y1*INPUT_FEATURES(ind(i),:);  %updating weights
        
        b2=b2+alpha*Y2;  %updating hidden layer biased values vector
        b1=b1+alpha*Y1;  %updating output layer biased values vector
    
    end

end


%mean(I) % average error
stem(I);                         %ERROR minimization in total epochs PLOT
title('Plot of Cost Function');
xlabel('Epoch');
ylabel('Sum of Error');


figure                           %training PLOT
plot(OUTPUTS(ind));
hold on;
plot(out,'g');
title('Training');
 
save maxVec.mat maxVec;   %save maxVec for test
save minVec.mat minVec;   %save minVec for test
save weight1.mat w1;      %save final w1 matrix after training for test
save weight2.mat w2;      %save final w2 matrix after training for test
save Biased1.mat b1;      %save final b1 matrix after training for test
save Biased2.mat b2;      %save final b2 matrix after training for test
end
