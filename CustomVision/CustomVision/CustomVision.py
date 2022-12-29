from azure.cognitiveservices.vision.customvision.prediction import CustomVisionPredictionClient
from msrest.authentication import ApiKeyCredentials
from matplotlib import pyplot as plt
from PIL import Image,ImageDraw, ImageFont
import numpy as np
import os

def main():
    try:
        prediction_endpoint = 'https://southcentralus.api.cognitive.microsoft.com/'
        prediction_key = 'e9d997e018dc45109cd8d43f1d0e9f75'
        project_id = '3cdb0837-1b50-492e-b1a5-e16c7cc27414'
        model_name = 'Iteration1'
        credentials = ApiKeyCredentials(in_headers={"Prediction-key" : prediction_key})
        client = CustomVisionPredictionClient(endpoint=prediction_endpoint, credentials=credentials)

        image_file = 'D:/training/c#programs/cognitiveServices/22.jfif'
        print('Detecting objects in', image_file)
        image = Image.open(image_file)
        h, w, ch = np.array(image).shape

        with open(image_file, mode='rb') as image_data:
            results = client.classify_image(project_id, model_name,image_data.read())

            fig = plt.figure(figsize=(8, 8))
            plt.axis('off')

            draw = ImageDraw.Draw(image)
            lineWidth = int(w/100)
            color = 'magenta'
            for prediction in results.predictions:
                plt.annotate(prediction.tag_name + ": {0:.2f}%".format(prediction.probability * 100),(8,8), backgroundcolor=color)
            plt.imshow(image)
            outputfile = 'out.jpg'
            fig.savefig(outputfile)
            print("File saved")
    except Exception as ex:
        print(ex)
if __name__ == "__main__":
    main()