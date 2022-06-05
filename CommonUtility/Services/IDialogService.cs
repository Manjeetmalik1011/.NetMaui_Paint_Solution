namespace DotNetMauiDrawingViewPaintAppSample.Services;

public interface IDialogService
{
	Task<bool> SaveFileDialog(Stream stream, string fileExtension, CancellationToken cancellationToken);
	Task<Stream> OpenFileDialog(CancellationToken cancellationToken);
}