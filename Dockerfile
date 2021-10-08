# escape=`

FROM mcr.microsoft.com/windows/servercore:ltsc2019

# Copy Executable
COPY ./WcfService/bin/Debug/*.* C:/WcfService/
COPY ./WcfClient/bin/Debug/*.* C:/WcfClient/

# Start the service
ENTRYPOINT ["C:\\WcfService\\WcfService.exe"]