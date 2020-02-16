import io
import os

# Imports the Google Cloud client library
from google.cloud import vision
from google.cloud.vision import types
from google.cloud import storage

# Explicitly use service account credentials by specifying the private key
# file.
#storage_client = storage.Client.from_service_account_json(
 #   'detecting cars-d518b4921d4a.json')

# Instantiates a client
client = vision.ImageAnnotatorClient()

# The name of the image file to annotate

#file_name = os.path.abspath('Madison.jpg') #
file_name = os.path.abspath('empty.jpg')
#file_name = os.path.abspath('smallValencia.jpg')


# Loads the image into memory
with io.open(file_name, 'rb') as image_file:
    content = image_file.read()

image = types.Image(content=content)

# Performs label detection on the image file
response = client.label_detection(image=image)
labels = response.label_annotations

objects = client.object_localization(
    image=image).localized_object_annotations

print('Labels:')
for label in labels:
    print(label.description)

print('Number of objects found: {}'.format(len(objects)))
for object_ in objects:
    print('\n{} (confidence: {})'.format(object_.name, object_.score))
    print('Normalized bounding polygon vertices: ')
    for vertex in object_.bounding_poly.normalized_vertices:
        print(' - ({}, {})'.format(vertex.x, vertex.y))