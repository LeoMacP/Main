document.addEventListener('DOMContentLoaded', () => {
    console.log('DOM fully loaded and parsed');
    
    // API URL to get all countries
    const apiUrl = 'https://restcountries.com/v3.1/all';
    const container = document.getElementById('countries-container');
  
    fetch(apiUrl)
    // Make sure that it is working properly
      .then(response => {
        if (!response.ok) {
          throw new Error('Network response was not ok ' + response.statusText);
        }
        //turn it into json object so you can manipulate
        return response.json();
      })
      // little function to read the response
      .then(data => {
        console.log('Data fetched:', data); // checking if it is working properly
        
        // Creating a individual box for each country
        data.forEach(country => {
          const countryElement = document.createElement('div');
          countryElement.classList.add('country');
        
          const flag = document.createElement('img');
          flag.src = country.flags.svg;
          flag.alt = `${country.name.common} flag`;
          
          const name = document.createElement('span');
          name.textContent = country.name.common;
          //Adding google maps
          const link = document.createElement('a');
          link.href = `https://www.google.com/maps/place/${country.name.common}`;
          link.target = '_blank';
          link.textContent = 'View on Google Maps';
          
          countryElement.appendChild(flag);
          countryElement.appendChild(name);
          countryElement.appendChild(link);
          container.appendChild(countryElement);
        });
      })
      .catch(error => {
        console.error('There has been a problem with your fetch operation:', error);
      });
  });
  